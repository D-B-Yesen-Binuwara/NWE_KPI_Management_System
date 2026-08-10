// Coordinates Azure account authentication with the application's service-ID verification step.

import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { MsalBroadcastService, MsalService } from '@azure/msal-angular';
import { first } from 'rxjs/operators';
import { loginRequest } from '../../auth-config';
import { AuthService } from '../../services/auth.service';

// The page is standalone and imports only the common and form features used by its template.

@Component({
    selector: 'app-login',
    standalone: true,
    imports: [CommonModule, FormsModule],
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    // Service ID supplied for the application-level user lookup after Azure authentication.
    serviceId = '';
    // Disables authentication controls while an Azure or backend request is in progress.
    loading = false;
    // User-facing validation or authentication failure message.
    error = '';
    // Indicates whether MSAL has supplied an Azure account for the second login step.
    isAzureAuthenticated = false;
    // Email/username from the active Azure account sent to backend verification.
    azureEmail = '';

    // MSAL handles Azure sessions; AuthService verifies the application service ID.
    constructor(
        private authService: AuthService,
        private router: Router,
        private route: ActivatedRoute,
        private msalService: MsalService,
        private msalBroadcastService: MsalBroadcastService
    ) { }

    // Restores an MSAL session or redirect result before checking the application's own session.
    ngOnInit(): void {
        console.log('[Login] Checking for existing Azure session and redirect results...');

        // Process the redirect result first so the account is available after returning from Microsoft.
        this.msalService.instance.handleRedirectPromise().then(result => {
            if (result) {
                // A redirect result may be absent or may not contain an account, so guard both uses.
				if (result.account) {
    console.log('[Login] Redirect success:', result.account.username);

    this.setAzureState(result.account.username);
}
                this.msalService.instance.setActiveAccount(result.account);
			   if (result.account) {
    console.log('[Login] Redirect success:', result.account.username);

    this.setAzureState(result.account.username);
}
                return; // Do not overwrite the redirect account with a later cached-account lookup.
            }

            // When no redirect just completed, reuse the active account or select the first cached account.
            const activeAccount = this.msalService.instance.getActiveAccount();
            const allAccounts = this.msalService.instance.getAllAccounts();

            if (activeAccount) {
                console.log('[Login] Active account found:', activeAccount.username);
                this.setAzureState(activeAccount.username);
            } else if (allAccounts.length > 0) {
                console.log('[Login] No active account, setting first available:', allAccounts[0].username);
                this.msalService.instance.setActiveAccount(allAccounts[0]);
                this.setAzureState(allAccounts[0].username);
            }
        }).catch(err => {
            console.error('[Login] MSAL handleRedirectPromise error:', err);
            this.error = 'Azure login failed to process redirect';
        });

        // Existing application sessions bypass the login form and return to the dashboard.
        if (this.authService.userValue) {
            this.router.navigate(['/dashboard']);
        }
    }

    // Copies the selected Azure account into the state consumed by the template and backend request.
    private setAzureState(email: string) {
        this.isAzureAuthenticated = true;
        this.azureEmail = email;
    }

    // Verifies the required Azure account and service ID before entering the application.
    login() {
        this.loading = true;
        this.error = '';

        // Azure authentication is mandatory; a service ID alone is not sufficient.
        if (!this.isAzureAuthenticated || !this.azureEmail) {
            this.error = 'Please sign in with Microsoft first';
            this.loading = false;
            return;
        }

        // The backend receives both independent proofs: the authenticated Azure identity and the registered service ID.
        this.authService.verifyAzureLogin(this.azureEmail, this.serviceId)
            .pipe(first())
            .subscribe({
                next: () => {
                    this.handleLoginSuccess();
                },
                error: (error) => {
                    console.error('Authentication Error:', error);
                    this.error = this.getLoginErrorMessage(error);
                    this.loading = false;
                }
            });
    }

    // Converts transport and backend errors into messages suitable for the login page.
    private getLoginErrorMessage(error: any): string {
        if (error?.status === 0 || error?.error instanceof ProgressEvent) {
            return 'Cannot reach the backend. Please check that the API is running and the browser can access it.';
        }

        const backendMessage = error?.error;
        if (typeof backendMessage === 'string' && backendMessage.trim()) {
            return backendMessage;
        }

        if (backendMessage?.message) {
            return backendMessage.message;
        }

        return 'Authentication failed. Please verify your Service ID is registered in the system.';
    }

    // Starts the MSAL redirect flow; the browser returns to this component after Azure completes.
    signInWithAzure() {
        this.loading = true;
        this.error = '';
        console.log('[Login] Initiating loginRedirect...');
        this.msalService.loginRedirect(loginRequest);
    }

    // Clears the local two-step state and signs the user out of the Azure session.
    cancelAzure() {
        this.isAzureAuthenticated = false;
        this.azureEmail = '';
        this.serviceId = '';
        this.error = '';
        console.log('[Login] Logging out from Azure...');
        this.msalService.logoutRedirect();
    }

    private handleLoginSuccess() {
        // Return to the route requested before login, or use the dashboard as the default destination.
        const returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/dashboard';
        this.router.navigate([returnUrl]);
    }
}
