// Provides the header control that enters the configured Overall KPI section.

import { Component, Input, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { NavOption } from '../../page-config';

// The component is standalone so it can be placed directly in page navigation templates.

@Component({
  selector: 'app-overall-kpi-dropdown',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './overall-kpi-dropdown.component.html',
  styleUrls: ['./overall-kpi-dropdown.component.scss']
})
export class OverallKpiDropdownComponent {
  // Navigation entries are supplied by the parent so route configuration stays centralized.
  @Input() options: NavOption[] = [];
  // Notifies the parent after navigation so an open menu can be collapsed.
  @Output() closeMenu = new EventEmitter<void>();
  // Exposes the selected route to any parent that tracks the active navigation item.
  @Output() selection = new EventEmitter<string>();

  // Router is used to navigate without reloading the application shell.
  constructor(private router: Router) {}

  // Navigates to the first configured option, then informs the parent of the result.
  onNavigate(): void {
    const target = this.options[0]?.path;
    if (!target) {
      // A missing route configuration is ignored so the header does not attempt invalid navigation.
      return;
    }

    this.router.navigate([target]).then(() => {
      this.closeMenu.emit();
      this.selection.emit(target);
    }).catch((error) => {
      // The menu still closes after a failed navigation, while the error remains visible in the console.
      console.error('Navigation error:', error);
      this.closeMenu.emit();
    });
  }
}

