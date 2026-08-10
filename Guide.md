# SLT Network KPI User Guide

## 1. Purpose and audience

This guide explains how to sign in, navigate the application, review KPI results, calculate results for a reporting period, enter platform data, and use the administration pages. Available pages and actions depend on the user's role and page permissions.

## 2. Sign in

1. Open the application URL supplied by the system administrator.
2. Enter the credentials requested by the login screen.
3. After successful authentication, use the navigation controls to open Dashboard, Overall KPI, Analytics, Platform KPI, or Administration pages.
4. If access is denied, contact an administrator to verify the account role and page assignment.

## 3. Navigation at a glance

| Section | What it is used for |
| --- | --- |
| Dashboard | Area-level view of the calculated overall KPI percentage for one month. |
| Overall KPI Table | Detailed KPI rows and point calculations for one month. |
| Analytics | Period comparison and cumulative-style analysis across a month range. |
| Platform KPI | Source data entry and review for individual KPI platforms. |
| Admin | User, region, KPI definition, target, email, and platform administration. |

## 4. Dashboard

### 4.1 Select a reporting period

Use the Month and Year selectors in the Dashboard header. Changing either selector reloads the stored results for that period.

### 4.2 Calculate the selected month

Select the required month and year, then click **Calculate**. The application sends the selected period to the overall KPI calculation service. After the calculation completes, the Dashboard reloads and displays the newly persisted values.

Calculation may take time because the service reads the platform source tables, applies KPI matching and weighting rules, and saves the result for each area. Do not click the button repeatedly while it shows **Calculating...**.

The Dashboard Calculate action calculates one month only. To calculate several months, use Analytics.

### 4.3 Read the dashboard

- Each region is shown as a region card.
- Each meter represents an operational area or LEA.
- The circular percentage is the area's overall KPI percentage.
- Meter colors indicate the score range: green for high values, yellow for middle values, and red for low values.
- Click a meter to open its details.

### 4.4 Area details

The details window shows the region, province, network engineer, LEA, overall KPI percentage, total maximum points, total points achieved, and the individual KPI rows used for the area's score.

If an area has no persisted result for the selected month, its displayed percentage can be zero and its detail table can be empty. Calculate the selected month after confirming that the source platform data is available.

## 5. Overall KPI Table

1. Open **Overall KPI Table**.
2. Select the required month and year.
3. Review KPI achievements, maximum points, points achieved, and area totals.
4. Click **Calculate** to recalculate and persist the selected month.
5. Use **Export to Excel** when a spreadsheet copy is required.

The Overall KPI page and the main Dashboard use the same persisted `OverallKpiResults` data. Calculating on either page refreshes the stored results for the selected month.

For the special 2026 Q1 period, the application may redirect the January-March view to the Q1 page. Follow the Q1 page instructions when that notice is shown.

## 6. Analytics

### 6.1 Select a period

Choose a Year, Start Month, and End Month. The start month cannot be later than the end month.

### 6.2 Calculate a period

Click **Calculate** to calculate and persist every month in the selected range. When the calculation finishes, Analytics loads the period results and updates both available views.

The Analytics Calculate action is a range operation. It calls the monthly overall calculation for each month in the selected range before retrieving the aggregated analytics response.

### 6.3 Table View

Table View displays KPI rows by area, including achieved values, maximum points, and points achieved. Use it when detailed KPI-by-KPI comparison is required.

### 6.4 Dashboard View

Dashboard View groups results by region, province, and network engineer. Each engineer card shows the period overall percentage, progress bar, maximum points, and achieved points.

The Analytics Dashboard View is not the same route as the main Dashboard. It uses the same calculated result records but aggregates the selected month range for analysis.

## 7. Platform KPI pages

Platform pages provide the source values used by the overall calculation. Depending on the platform, users may enter monthly counters, percentages, maintenance records, verification state, or target-related values.

The platform pages include:

- Service Fulfilment
- Enterprise KPI
- Other KPI
- IP NW OP
- Wireline Access NW / BB ANW
- OTN OP
- Tower Maintenance
- Routine Maintenance
- Other Operator

After changing platform data, recalculate the affected month or range from Dashboard, Overall KPI, or Analytics before expecting the consolidated values to change.

## 8. Administration

Administrative pages are available only to users with the required role and page access. They are used to manage:

- Users and roles
- Regions, provinces, network engineers, and LEA mappings
- KPI definitions, categories, targets, weightages, and applicable points
- Platform-specific data and targets
- Email recipients and reporting settings

Changes to KPI definitions, target values, point allocations, or area mappings can change later calculations. Confirm configuration before calculating a reporting period.

## 9. How calculation results are produced

The overall calculation combines platform source data with KPI definitions. In general it:

1. Loads source records for the selected month and year.
2. Matches source KPI names to the configured KPI definitions.
3. Calculates an achieved percentage using the platform-specific formula.
4. Allocates maximum points to areas using the configured weighting method.
5. Converts the achieved percentage into points achieved, including target-based scaling where applicable.
6. Calculates each area's overall percentage.
7. Stores the result for later Dashboard, Overall KPI, and Analytics retrieval.

See [kpi_calculations_documentation.txt](kpi_calculations_documentation.txt) for the detailed formulas and source tables.

## 10. Troubleshooting

### Dashboard values are zero or missing

Confirm the selected month and year, confirm that source data exists for that period, and click **Calculate**. The Dashboard reads stored results and does not automatically recalculate when filters change.

### Analytics shows no data

Confirm that the selected range is valid and click **Calculate**. Analytics requires persisted monthly overall results for the selected range.

### A calculation fails

Check the error message, verify that the backend is running, verify database connectivity, and confirm that the required KPI definitions and source records are configured. If the issue continues, provide the selected period and the affected platform to the system administrator.

### A user cannot edit a page

Editing is controlled by role and page assignment. Ask an administrator to review the user's access rather than attempting to change the browser state.

### Values look stale after source data changes

The previous calculation remains persisted until the period is recalculated. Run the relevant month or range calculation again.

## 11. Glossary

| Term | Meaning |
| --- | --- |
| KPI | Key Performance Indicator. |
| Area / LEA | Operational area used to group KPI results. |
| Achieved KPI | The percentage achieved for one KPI and area. |
| Maximum points | The maximum score allocated to a KPI for an area. |
| Points achieved | The score earned after applying the achievement and target rules. |
| Overall KPI percentage | Total points achieved divided by total maximum points, multiplied by 100. |
| Persisted result | A calculated result saved in the `OverallKpiResults` table for later retrieval. |
