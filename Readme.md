# SLT Network KPI

SLT Network KPI is a full-stack application for capturing network-performance inputs, calculating KPI scores, and presenting results by operational area, network engineer, region, and reporting period.

The solution contains:

- An ASP.NET Core Web API and SQL Server data layer in `backend/`.
- An Angular application in `frondend/`.
- Role- and page-based access control for operational and administrative functions.
- Persisted overall KPI results that can be consumed by the Overall KPI page, Dashboard, and Analytics.

## Main capabilities

| Area | Purpose | Route |
| --- | --- | --- |
| Dashboard | View area-level overall KPI percentages and open KPI details. | `/dashboard` |
| Overall KPI | Review KPI-by-area results for one month and export the table. | `/overall/current-month` |
| Analytics | Compare KPI performance across a selected month range in table or dashboard form. | `/analytics` |
| Platform KPI pages | Enter and review source data for service fulfilment, enterprise, other operator, IP NW OP, Wireline Access NW, OTN OP, tower maintenance, and routine maintenance. | `/platform/...` |
| Administration | Manage users, regions, KPI definitions, targets, email recipients, and platform data. | `/admin/...` |

## Technology stack

### Backend

- ASP.NET Core Web API
- C# and Entity Framework Core
- SQL Server
- JWT authentication and claims-based authorization
- Swagger/OpenAPI for API inspection

### Frontend

- Angular 21
- TypeScript
- RxJS and Angular Router
- SCSS
- ExcelJS and SheetJS for spreadsheet export

## Repository structure

```text
slt-network-kpi/
├── backend/                 # ASP.NET Core API
│   ├── Controllers/         # API endpoints and KPI aggregation
│   ├── Data/                # EF Core DbContext
│   ├── DTOs/                # API response/request models
│   ├── Helpers/             # Authentication and authorization helpers
│   ├── Migrations/          # EF Core migrations
│   ├── Models/              # Database entities
│   └── Services/            # Calculation and integration services
├── frondend/                # Angular application (folder name retained for compatibility)
│   ├── src/app/              # Components, routes, services, guards, and utilities
│   ├── src/assets/           # Static assets
│   └── src/environments/     # API endpoint configuration
├── Guide.md                 # End-user guide
├── kpi_calculations_documentation.txt
└── Readme.md
```

## KPI result lifecycle

Source values are entered on platform pages and stored in platform-specific tables. The overall calculation then:

1. Loads KPI definitions and source metrics for the selected month and year.
2. Matches source metrics to KPI definitions and operational areas.
3. Calculates the achieved percentage for each KPI.
4. Allocates maximum points and calculates points achieved.
5. Calculates the overall percentage for each area.
6. Persists the result in `OverallKpiResults`.

The Dashboard and Analytics pages read persisted results. They do not silently recalculate when the month or year changes. Use the Dashboard Calculate button for one month, the Overall KPI Calculate button for one month, or the Analytics Calculate button for a month range.

## Prerequisites

- .NET SDK compatible with `backend/backend.csproj`.
- Node.js and npm compatible with the Angular toolchain.
- SQL Server accessible from the backend.
- A database account with permission to create/update the configured database during development.

## Local setup

### 1. Configure the database

Update `backend/appsettings.json` or an environment-specific configuration file with the SQL Server connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=NWKPI;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

The backend applies pending EF Core migrations during startup. Review the migration strategy before using the application in a production environment.

### 2. Start the API

From the repository root:

```powershell
dotnet run --project backend
```

The development launch settings expose HTTP on `http://localhost:5043` and HTTPS on `https://localhost:7251`.

### 3. Install and start the Angular application

```powershell
Set-Location frondend
npm install
npm start
```

The development server uses `frondend/proxy.conf.json` to forward `/api` requests to the backend. The frontend development environment uses the relative API base `/api`; production uses the URL configured in `src/environments/environment.prod.ts`.

## Build and test

Backend build:

```powershell
dotnet build backend/backend.csproj
```

Frontend build:

```powershell
Set-Location frondend
npm run build
```

Frontend tests:

```powershell
Set-Location frondend
npm test
```

## Access and roles

The application uses authenticated users, roles, and page-level access rules. The main roles are `User`, `PlatformAdmin`, `Admin`, and `SuperAdmin`. The exact pages a user can view or edit depend on the assigned role and page permissions. Administrative routes should not be treated as public APIs even when a development endpoint has relaxed access for integration purposes.

## Related documentation

- [Guide.md](Guide.md) contains step-by-step instructions for using the application.
- [kpi_calculations_documentation.txt](kpi_calculations_documentation.txt) describes KPI formulas, weighting, source tables, persistence, and cumulative analytics behavior.
