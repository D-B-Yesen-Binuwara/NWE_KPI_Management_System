D:\Learning\Projects\ASP.NET\SLT-Telecom\EXTRA\slt-network-kpi\backend>dotnet run
Using launch settings from D:\Learning\Projects\ASP.NET\SLT-Telecom\EXTRA\slt-network-kpi\backend\Properties\launchSettings.json...
Building...
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (11ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [r].[RoleName]
      FROM [dbo].[Roles] AS [r]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [p].[PageId]
      FROM [dbo].[Page] AS [p]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [p].[PageId], [p].[CreatedAt], [p].[PageCode], [p].[PageName]
      FROM [dbo].[Page] AS [p]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT TOP(1) [u].[UserId], [u].[CreatedAt], [u].[Email], [u].[IsActive], [u].[LastLogin], [u].[Name], [u].[RoleId], [u].[ServiceId], [u].[UpdatedAt]
      FROM [dbo].[Users] AS [u]
      WHERE [u].[ServiceId] = N'admin'
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT TOP(1) [r].[RoleId], [r].[CreatedAt], [r].[RoleName]
      FROM [dbo].[Roles] AS [r]
      WHERE [r].[RoleName] = N'PlatformAdmin'
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT TOP(1) [u].[UserId], [u].[CreatedAt], [u].[Email], [u].[IsActive], [u].[LastLogin], [u].[Name], [u].[RoleId], [u].[ServiceId], [u].[UpdatedAt]
      FROM [dbo].[Users] AS [u]
      WHERE [u].[ServiceId] = N'30001'
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (37ms) [Parameters=[], CommandType='Text', CommandTimeout='30']

      IF OBJECT_ID(N'dbo.msanmtcdata', N'U') IS NOT NULL
      AND EXISTS (
          SELECT 1
          FROM sys.columns c
          INNER JOIN sys.types t ON c.user_type_id = t.user_type_id
          WHERE c.object_id = OBJECT_ID(N'dbo.msanmtcdata')
            AND c.name = N'year'
            AND t.name IN (N'varchar', N'nvarchar', N'char', N'nchar')
      )
      BEGIN
          IF EXISTS (
              SELECT 1
              FROM dbo.msanmtcdata
              WHERE [year] IS NOT NULL
                AND LTRIM(RTRIM([year])) <> ''
                AND TRY_CONVERT(int, LTRIM(RTRIM([year]))) IS NULL
          )
          BEGIN
              THROW 50001, 'Cannot convert dbo.msanmtcdata.year to int because one or more values are not numeric.', 1;
          END;

          UPDATE dbo.msanmtcdata
          SET [year] = NULL
          WHERE [year] IS NOT NULL
            AND LTRIM(RTRIM([year])) = '';

          ALTER TABLE dbo.msanmtcdata ALTER COLUMN [year] int NULL;
      END;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (5ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [m].[id], [m].[attended], [m].[Cumulative_Achieved], [m].[Cumulative_Sched], [m].[designation], [m].[is_verified], [m].[month], [m].[scheduled], [m].[year]
      FROM [dbo].[msanmtcdata] AS [m]
MSAN cumulative backfill completed. Records: 240, Groups: 20, Rows updated: 0.
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (15ms) [Parameters=[], CommandType='Text', CommandTimeout='30']

      IF OBJECT_ID(N'dbo.slbnmtcdata', N'U') IS NOT NULL
      AND EXISTS (
          SELECT 1
          FROM sys.columns c
          INNER JOIN sys.types t ON c.user_type_id = t.user_type_id
          WHERE c.object_id = OBJECT_ID(N'dbo.slbnmtcdata')
            AND c.name = N'year'
            AND t.name IN (N'varchar', N'nvarchar', N'char', N'nchar')
      )
      BEGIN
          IF EXISTS (
              SELECT 1
              FROM dbo.slbnmtcdata
              WHERE [year] IS NOT NULL
                AND LTRIM(RTRIM([year])) <> ''
                AND TRY_CONVERT(int, LTRIM(RTRIM([year]))) IS NULL
          )
          BEGIN
              THROW 50002, 'Cannot convert dbo.slbnmtcdata.year to int because one or more values are not numeric.', 1;
          END;

          UPDATE dbo.slbnmtcdata
          SET [year] = NULL
          WHERE [year] IS NOT NULL
            AND LTRIM(RTRIM([year])) = '';

          ALTER TABLE dbo.slbnmtcdata ALTER COLUMN [year] int NULL;
      END;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [s].[id], [s].[attended], [s].[Cumulative_Achieved], [s].[Cumulative_Sched], [s].[designation], [s].[is_verified], [s].[month], [s].[scheduled], [s].[year]
      FROM [dbo].[slbnmtcdata] AS [s]
SLBN cumulative backfill completed. Records: 240, Groups: 20, Rows updated: 0.
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [t].[id], [t].[attended], [t].[Cumulative_Achieved], [t].[Cumulative_Scheduled], [t].[designation], [t].[is_verified], [t].[month], [t].[scheduled], [t].[year]
      FROM [dbo].[towermtcdata] AS [t]
Tower MTC cumulative backfill completed. Records: 240, Groups: 20, Rows updated: 0.
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5043
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\Learning\Projects\ASP.NET\SLT-Telecom\EXTRA\slt-network-kpi\backend
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (31ms) [Parameters=[@__serviceId_0='?' (Size = 20)], CommandType='Text', CommandTimeout='30']
      SELECT TOP(1) [u].[UserId], [u].[CreatedAt], [u].[Email], [u].[IsActive], [u].[LastLogin], [u].[Name], [u].[RoleId], [u].[ServiceId], [u].[UpdatedAt], [r].[RoleId], [r].[CreatedAt], [r].[RoleName]
      FROM [dbo].[Users] AS [u]
      INNER JOIN [dbo].[Roles] AS [r] ON [u].[RoleId] = [r].[RoleId]
      WHERE [u].[ServiceId] = @__serviceId_0
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p1='?' (DbType = Int32), @p0='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      UPDATE [dbo].[Users] SET [LastLogin] = @p0
      OUTPUT 1
      WHERE [UserId] = @p1;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[@__user_UserId_0='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [u].[PageId]
      FROM [dbo].[UserPageAccess] AS [u]
      WHERE [u].[UserId] = @__user_UserId_0 AND [u].[PageId] IN (CAST(1 AS tinyint), CAST(2 AS tinyint), CAST(3 AS tinyint), CAST(4 AS tinyint), CAST(6 AS tinyint), CAST(7 AS tinyint), CAST(8 AS tinyint), CAST(9 AS tinyint), CAST(10 AS tinyint))
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__user_UserId_0='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [p].[PageId]
      FROM [dbo].[PlatformKpiAssignment] AS [p]
      WHERE [p].[UserId] = @__user_UserId_0 AND [p].[PageId] IN (CAST(1 AS tinyint), CAST(2 AS tinyint), CAST(3 AS tinyint), CAST(4 AS tinyint), CAST(6 AS tinyint), CAST(7 AS tinyint), CAST(8 AS tinyint), CAST(9 AS tinyint), CAST(10 AS tinyint))
month: 4
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [k].[id], [k].[category], [k].[contactNo], [k].[createdAt], [k].[descriptionOfKPI], [k].[engineerResponsible], [k].[keyPerformanceIndicators], [k].[perspectives], [k].[pointsApplicable], [k].[strategicObjectives], [k].[totalPoints], [k].[unit], [k].[updatedAt], [k].[weightage]
      FROM [dbo].[KpiDefinition] AS [k]
      ORDER BY [k].[id]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Byte), @__year_1='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SELECT [i].[id], [i].[area_code], [i].[ip_nw_op_kpi_id], [i].[month], [i].[total_minutes], [i].[total_nodes], [i].[unavailable_minutes], [i].[year]
      FROM [dbo].[IpNwOpKpiMetrics] AS [i]
      WHERE [i].[month] = @__month_0 AND [i].[year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Byte), @__year_1='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SELECT [b].[id], [b].[bb_anw_kpi_id], [b].[month], [b].[node_code], [b].[total_minutes], [b].[total_nodes], [b].[unavailable_minutes], [b].[year]
      FROM [dbo].[BbAnwKpiNode] AS [b]
      WHERE [b].[month] = @__month_0 AND [b].[year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Byte), @__year_1='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], [o].[Month], [o].[OtnOp1Id], [o].[Site], [o].[TotalMinutes], [o].[TotalNodes], [o].[UnavailableMinutes], [o].[Year]
      FROM [dbo].[OtnOp1Metrics] AS [o]
      WHERE [o].[Month] = @__month_0 AND [o].[Year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Byte), @__year_1='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], [o].[LinksSlaNotViolated], [o].[Month], [o].[OtnOp2Id], [o].[Site], [o].[TotalFailedLinks], [o].[Year]
      FROM [dbo].[OtnOp2Metrics] AS [o]
      WHERE [o].[Month] = @__month_0 AND [o].[Year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Byte), @__year_1='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SELECT [s].[id], [s].[area_code], [s].[kpi_value], [s].[month], [s].[ServiceFulfilmentKpiId], [s].[year]
      FROM [dbo].[ServiceFulfilmentKpiMetrics] AS [s]
      WHERE [s].[month] = @__month_0 AND [s].[year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Int32), @__year_1='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [e].[Id], [e].[CreatedAt], [e].[EnterpriseKpiId], [e].[KpiValue], [e].[month], [e].[Site], [e].[Target], [e].[UpdatedAt], [e].[year]
      FROM [dbo].[EnterpriseKpiMetrics] AS [e]
      WHERE [e].[month] = @__month_0 AND [e].[year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (3ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Byte), @__year_1='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], [o].[kpi_value], [o].[Month], [o].[OtherOperatorKpiId], [o].[Site], [o].[Target], [o].[Year]
      FROM [dbo].[OtherOperatorKpiMetrics] AS [o]
      WHERE [o].[Month] = @__month_0 AND [o].[Year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Int32), @__year_1='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [t].[Id], [t].[Designation], [t].[Month], [t].[Node_Count], [t].[Percentage], [t].[Year]
      FROM [dbo].[Telemetry] AS [t]
      WHERE [t].[Month] = @__month_0 AND [t].[Year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [r].[id], [r].[EngName], [r].[lea_code], [r].[network_engineer], [r].[province], [r].[region]
      FROM [regiondata] AS [r]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT DISTINCT [t5].[designation]
      FROM (
          SELECT [m].[designation]
          FROM [dbo].[msanmtcdata] AS [m]
          UNION ALL
          SELECT [i].[designation]
          FROM [dbo].[ipnwmtcdata] AS [i]
          UNION ALL
          SELECT [s].[designation]
          FROM [dbo].[slbnmtcdata] AS [s]
          UNION ALL
          SELECT [t2].[designation]
          FROM [dbo].[towermtcdata] AS [t2]
          UNION ALL
          SELECT [t4].[Designation] AS [designation]
          FROM [dbo].[Telemetry] AS [t4]
          UNION ALL
          SELECT [p].[Designation] AS [designation]
          FROM [dbo].[PowerAndAC] AS [p]
      ) AS [t5]
      WHERE [t5].[designation] IS NOT NULL
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [i].[id], [i].[attended], [i].[Cumulative_Achieved], [i].[Cumulative_Sched], [i].[designation], [i].[is_verified], [i].[month], [i].[scheduled], [i].[year]
      FROM [dbo].[ipnwmtcdata] AS [i]
IPNW rows = 20
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [s].[id], [s].[attended], [s].[Cumulative_Achieved], [s].[Cumulative_Sched], [s].[designation], [s].[is_verified], [s].[month], [s].[scheduled], [s].[year]
      FROM [dbo].[slbnmtcdata] AS [s]
SLBN rows = 20
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [m].[id], [m].[attended], [m].[Cumulative_Achieved], [m].[Cumulative_Sched], [m].[designation], [m].[is_verified], [m].[month], [m].[scheduled], [m].[year]
      FROM [dbo].[msanmtcdata] AS [m]
MSAN rows = 20
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [t].[id], [t].[attended], [t].[Cumulative_Achieved], [t].[Cumulative_Scheduled], [t].[designation], [t].[is_verified], [t].[month], [t].[scheduled], [t].[year]
      FROM [dbo].[towermtcdata] AS [t]
Tower rows = 20
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__year_0='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [p].[Id], [p].[Attended], [p].[Cumulative_Achieved], [p].[Cumulative_Sched], [p].[Designation], [p].[is_verified], [p].[Month], [p].[Scheduled], [p].[Year]
      FROM [dbo].[PowerAndAC] AS [p]
      WHERE [p].[Year] = @__year_0
DEBUG: Retrieved 120 rows from PowerAndAC table for year 2026
DEBUG ROW: Designation='NW/CPN', Year=2026, Month=1, Sched=13, Attended=13
DEBUG ROW: Designation='NW/CPS', Year=2026, Month=1, Sched=11, Attended=5
DEBUG ROW: Designation='NW/EP', Year=2026, Month=1, Sched=8, Attended=8
DEBUG ROW: Designation='NW/NCP', Year=2026, Month=1, Sched=12, Attended=11
DEBUG ROW: Designation='NW/NP-1', Year=2026, Month=1, Sched=4, Attended=4
DEBUG ROW: Designation='NW/NP-2', Year=2026, Month=1, Sched=7, Attended=8
DEBUG ROW: Designation='NW/NWPE', Year=2026, Month=1, Sched=9, Attended=0
DEBUG ROW: Designation='NW/NWPW', Year=2026, Month=1, Sched=4, Attended=6
DEBUG ROW: Designation='NW/SAB', Year=2026, Month=1, Sched=12, Attended=12
DEBUG ROW: Designation='NW/SPE', Year=2026, Month=1, Sched=17, Attended=17
DEBUG ROW: Designation='NW/SPW', Year=2026, Month=1, Sched=7, Attended=5
DEBUG ROW: Designation='NW/UVA', Year=2026, Month=1, Sched=8, Attended=7
DEBUG ROW: Designation='NW/WPC-1', Year=2026, Month=1, Sched=9, Attended=3
DEBUG ROW: Designation='NW/WPC-2', Year=2026, Month=1, Sched=38, Attended=0
DEBUG ROW: Designation='NW/WPE', Year=2026, Month=1, Sched=14, Attended=17
DEBUG ROW: Designation='NW/WPN', Year=2026, Month=1, Sched=15, Attended=4
DEBUG ROW: Designation='NW/WPNE', Year=2026, Month=1, Sched=13, Attended=2
DEBUG ROW: Designation='NW/WPS', Year=2026, Month=1, Sched=9, Attended=12
DEBUG ROW: Designation='NW/WPSE', Year=2026, Month=1, Sched=7, Attended=0
DEBUG ROW: Designation='NW/WPSW', Year=2026, Month=1, Sched=12, Attended=16
DEBUG ROW: Designation='NW/CPN', Year=2026, Month=2, Sched=13, Attended=14
DEBUG ROW: Designation='NW/CPS', Year=2026, Month=2, Sched=12, Attended=16
DEBUG ROW: Designation='NW/EP', Year=2026, Month=2, Sched=8, Attended=8
DEBUG ROW: Designation='NW/NCP', Year=2026, Month=2, Sched=12, Attended=11
DEBUG ROW: Designation='NW/NP-1', Year=2026, Month=2, Sched=3, Attended=3
DEBUG ROW: Designation='NW/NP-2', Year=2026, Month=2, Sched=7, Attended=3
DEBUG ROW: Designation='NW/NWPE', Year=2026, Month=2, Sched=10, Attended=19
DEBUG ROW: Designation='NW/NWPW', Year=2026, Month=2, Sched=5, Attended=5
DEBUG ROW: Designation='NW/SAB', Year=2026, Month=2, Sched=12, Attended=12
DEBUG ROW: Designation='NW/SPE', Year=2026, Month=2, Sched=17, Attended=18
DEBUG ROW: Designation='NW/SPW', Year=2026, Month=2, Sched=7, Attended=10
DEBUG ROW: Designation='NW/UVA', Year=2026, Month=2, Sched=8, Attended=10
DEBUG ROW: Designation='NW/WPC-1', Year=2026, Month=2, Sched=9, Attended=25
DEBUG ROW: Designation='NW/WPC-2', Year=2026, Month=2, Sched=39, Attended=4
DEBUG ROW: Designation='NW/WPE', Year=2026, Month=2, Sched=14, Attended=12
DEBUG ROW: Designation='NW/WPN', Year=2026, Month=2, Sched=15, Attended=26
DEBUG ROW: Designation='NW/WPNE', Year=2026, Month=2, Sched=14, Attended=25
DEBUG ROW: Designation='NW/WPS', Year=2026, Month=2, Sched=9, Attended=6
DEBUG ROW: Designation='NW/WPSE', Year=2026, Month=2, Sched=7, Attended=2
DEBUG ROW: Designation='NW/WPSW', Year=2026, Month=2, Sched=13, Attended=9
DEBUG ROW: Designation='NW/CPN', Year=2026, Month=3, Sched=13, Attended=14
DEBUG ROW: Designation='NW/CPS', Year=2026, Month=3, Sched=11, Attended=8
DEBUG ROW: Designation='NW/EP', Year=2026, Month=3, Sched=8, Attended=8
DEBUG ROW: Designation='NW/NCP', Year=2026, Month=3, Sched=12, Attended=11
DEBUG ROW: Designation='NW/NP-1', Year=2026, Month=3, Sched=4, Attended=4
DEBUG ROW: Designation='NW/NP-2', Year=2026, Month=3, Sched=7, Attended=13
DEBUG ROW: Designation='NW/NWPE', Year=2026, Month=3, Sched=9, Attended=0
DEBUG ROW: Designation='NW/NWPW', Year=2026, Month=3, Sched=4, Attended=4
DEBUG ROW: Designation='NW/SAB', Year=2026, Month=3, Sched=12, Attended=12
DEBUG ROW: Designation='NW/SPE', Year=2026, Month=3, Sched=17, Attended=20
DEBUG ROW: Designation='NW/SPW', Year=2026, Month=3, Sched=7, Attended=5
DEBUG ROW: Designation='NW/UVA', Year=2026, Month=3, Sched=8, Attended=13
DEBUG ROW: Designation='NW/WPC-1', Year=2026, Month=3, Sched=9, Attended=2
DEBUG ROW: Designation='NW/WPC-2', Year=2026, Month=3, Sched=38, Attended=0
DEBUG ROW: Designation='NW/WPE', Year=2026, Month=3, Sched=14, Attended=5
DEBUG ROW: Designation='NW/WPN', Year=2026, Month=3, Sched=15, Attended=13
DEBUG ROW: Designation='NW/WPNE', Year=2026, Month=3, Sched=13, Attended=8
DEBUG ROW: Designation='NW/WPS', Year=2026, Month=3, Sched=9, Attended=9
DEBUG ROW: Designation='NW/WPSE', Year=2026, Month=3, Sched=7, Attended=0
DEBUG ROW: Designation='NW/WPSW', Year=2026, Month=3, Sched=12, Attended=12
DEBUG ROW: Designation='NW/CPN', Year=2026, Month=4, Sched=13, Attended=13
DEBUG ROW: Designation='NW/CPS', Year=2026, Month=4, Sched=12, Attended=17
DEBUG ROW: Designation='NW/EP', Year=2026, Month=4, Sched=8, Attended=7
DEBUG ROW: Designation='NW/NCP', Year=2026, Month=4, Sched=12, Attended=11
DEBUG ROW: Designation='NW/NP-1', Year=2026, Month=4, Sched=3, Attended=3
DEBUG ROW: Designation='NW/NP-2', Year=2026, Month=4, Sched=7, Attended=3
DEBUG ROW: Designation='NW/NWPE', Year=2026, Month=4, Sched=10, Attended=1
DEBUG ROW: Designation='NW/NWPW', Year=2026, Month=4, Sched=5, Attended=3
DEBUG ROW: Designation='NW/SAB', Year=2026, Month=4, Sched=12, Attended=12
DEBUG ROW: Designation='NW/SPE', Year=2026, Month=4, Sched=17, Attended=15
DEBUG ROW: Designation='NW/SPW', Year=2026, Month=4, Sched=7, Attended=8
DEBUG ROW: Designation='NW/UVA', Year=2026, Month=4, Sched=8, Attended=4
DEBUG ROW: Designation='NW/WPC-1', Year=2026, Month=4, Sched=9, Attended=16
DEBUG ROW: Designation='NW/WPC-2', Year=2026, Month=4, Sched=39, Attended=0
DEBUG ROW: Designation='NW/WPE', Year=2026, Month=4, Sched=14, Attended=20
DEBUG ROW: Designation='NW/WPN', Year=2026, Month=4, Sched=15, Attended=17
DEBUG ROW: Designation='NW/WPNE', Year=2026, Month=4, Sched=14, Attended=19
DEBUG ROW: Designation='NW/WPS', Year=2026, Month=4, Sched=9, Attended=9
DEBUG ROW: Designation='NW/WPSE', Year=2026, Month=4, Sched=7, Attended=2
DEBUG ROW: Designation='NW/WPSW', Year=2026, Month=4, Sched=13, Attended=13
DEBUG ROW: Designation='NW/CPN', Year=2026, Month=5, Sched=13, Attended=0
DEBUG ROW: Designation='NW/CPS', Year=2026, Month=5, Sched=11, Attended=0
DEBUG ROW: Designation='NW/EP', Year=2026, Month=5, Sched=8, Attended=1
DEBUG ROW: Designation='NW/NCP', Year=2026, Month=5, Sched=12, Attended=2
DEBUG ROW: Designation='NW/NP-1', Year=2026, Month=5, Sched=4, Attended=0
DEBUG ROW: Designation='NW/NP-2', Year=2026, Month=5, Sched=7, Attended=1
DEBUG ROW: Designation='NW/NWPE', Year=2026, Month=5, Sched=9, Attended=0
DEBUG ROW: Designation='NW/NWPW', Year=2026, Month=5, Sched=4, Attended=0
DEBUG ROW: Designation='NW/SAB', Year=2026, Month=5, Sched=12, Attended=0
DEBUG ROW: Designation='NW/SPE', Year=2026, Month=5, Sched=17, Attended=0
DEBUG ROW: Designation='NW/SPW', Year=2026, Month=5, Sched=7, Attended=0
DEBUG ROW: Designation='NW/UVA', Year=2026, Month=5, Sched=8, Attended=0
DEBUG ROW: Designation='NW/WPC-1', Year=2026, Month=5, Sched=9, Attended=4
DEBUG ROW: Designation='NW/WPC-2', Year=2026, Month=5, Sched=38, Attended=1
DEBUG ROW: Designation='NW/WPE', Year=2026, Month=5, Sched=14, Attended=11
DEBUG ROW: Designation='NW/WPN', Year=2026, Month=5, Sched=15, Attended=4
DEBUG ROW: Designation='NW/WPNE', Year=2026, Month=5, Sched=13, Attended=27
DEBUG ROW: Designation='NW/WPS', Year=2026, Month=5, Sched=9, Attended=0
DEBUG ROW: Designation='NW/WPSE', Year=2026, Month=5, Sched=7, Attended=4
DEBUG ROW: Designation='NW/WPSW', Year=2026, Month=5, Sched=12, Attended=7
DEBUG ROW: Designation='NW/CPN', Year=2026, Month=6, Sched=13, Attended=0
DEBUG ROW: Designation='NW/CPS', Year=2026, Month=6, Sched=12, Attended=0
DEBUG ROW: Designation='NW/EP', Year=2026, Month=6, Sched=8, Attended=0
DEBUG ROW: Designation='NW/NCP', Year=2026, Month=6, Sched=12, Attended=0
DEBUG ROW: Designation='NW/NP-1', Year=2026, Month=6, Sched=3, Attended=0
DEBUG ROW: Designation='NW/NP-2', Year=2026, Month=6, Sched=7, Attended=0
DEBUG ROW: Designation='NW/NWPE', Year=2026, Month=6, Sched=10, Attended=0
DEBUG ROW: Designation='NW/NWPW', Year=2026, Month=6, Sched=5, Attended=0
DEBUG ROW: Designation='NW/SAB', Year=2026, Month=6, Sched=12, Attended=0
DEBUG ROW: Designation='NW/SPE', Year=2026, Month=6, Sched=17, Attended=0
DEBUG ROW: Designation='NW/SPW', Year=2026, Month=6, Sched=7, Attended=0
DEBUG ROW: Designation='NW/UVA', Year=2026, Month=6, Sched=8, Attended=0
DEBUG ROW: Designation='NW/WPC-1', Year=2026, Month=6, Sched=9, Attended=0
DEBUG ROW: Designation='NW/WPC-2', Year=2026, Month=6, Sched=39, Attended=0
DEBUG ROW: Designation='NW/WPE', Year=2026, Month=6, Sched=14, Attended=0
DEBUG ROW: Designation='NW/WPN', Year=2026, Month=6, Sched=15, Attended=0
DEBUG ROW: Designation='NW/WPNE', Year=2026, Month=6, Sched=14, Attended=0
DEBUG ROW: Designation='NW/WPS', Year=2026, Month=6, Sched=9, Attended=0
DEBUG ROW: Designation='NW/WPSE', Year=2026, Month=6, Sched=7, Attended=0
DEBUG ROW: Designation='NW/WPSW', Year=2026, Month=6, Sched=13, Attended=0
Power & AC rows = 20
IPNW results count = 20
SLBN results count = 20
MSAN results count = 20
Tower results count = 20
Power & AC results count = 20
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [i].[id], COALESCE([i].[network_engineer_kpi], N'')
      FROM [dbo].[IpNwOpKpi] AS [i]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [b].[id], COALESCE([b].[network_engineer_kpi], N'')
      FROM [dbo].[BbAnwKpi] AS [b]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], COALESCE([o].[NetworkEngineerKpi], N'')
      FROM [dbo].[OtnOp1] AS [o]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], COALESCE([o].[NetworkEngineerKpi], N'')
      FROM [dbo].[OtnOp2] AS [o]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [s].[id], COALESCE([s].[kpi], N'')
      FROM [dbo].[ServiceFulfilmentKpi] AS [s]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [e].[Id], COALESCE([e].[network_engineer_kpi], N'')
      FROM [dbo].[EnterpriseKpi] AS [e]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], COALESCE([o].[network_engineer_kpi], N'')
      FROM [dbo].[OtherOperatorKpi] AS [o]
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT [e].[Id], [e].[division], [e].[kpi_percent], [e].[network_engineer_kpi]
      FROM [dbo].[EnterpriseKpi] AS [e]
ENTERED TELEMETRY BLOCK
INSERTING Telemetry Network Availability Area=cenmd Achieved=85.00 Nodes=4 MaxPoints=20.6897
INSERTING Telemetry Network Availability Area=hk Achieved=10.00 Nodes=20 MaxPoints=103.4483
INSERTING Telemetry Network Availability Area=konkx Achieved=40.00 Nodes=10 MaxPoints=51.7241
INSERTING Telemetry Network Availability Area=ndrm Achieved=90.00 Nodes=14 MaxPoints=72.4138
INSERTING Telemetry Network Availability Area=awho Achieved=60.00 Nodes=10 MaxPoints=51.7241
INSERTING Telemetry Network Availability Area=ngwt Achieved=74.00 Nodes=9 MaxPoints=46.5517
INSERTING Telemetry Network Availability Area=gqkintb Achieved=84.00 Nodes=20 MaxPoints=103.4483
ENTERED IPNW BLOCK
INSERTING Routine Maintenance - IPNW Area=nwcpn Achieved=100 Nodes=13 MaxPoints=183.3333
INSERTING Routine Maintenance - IPNW Area=nwcps Achieved=100 Nodes=12 MaxPoints=169.2308
INSERTING Routine Maintenance - IPNW Area=nwep Achieved=87.50 Nodes=8 MaxPoints=112.8205
INSERTING Routine Maintenance - IPNW Area=nwncp Achieved=91.67 Nodes=12 MaxPoints=169.2308
INSERTING Routine Maintenance - IPNW Area=nwnp1 Achieved=100 Nodes=3 MaxPoints=42.3077
INSERTING Routine Maintenance - IPNW Area=nwnp2 Achieved=42.86 Nodes=7 MaxPoints=98.7179
INSERTING Routine Maintenance - IPNW Area=nwnwpe Achieved=10.0 Nodes=10 MaxPoints=141.0256
INSERTING Routine Maintenance - IPNW Area=nwnwpw Achieved=60.0 Nodes=5 MaxPoints=70.5128
INSERTING Routine Maintenance - IPNW Area=nwsab Achieved=100 Nodes=12 MaxPoints=169.2308
INSERTING Routine Maintenance - IPNW Area=nwspe Achieved=88.24 Nodes=17 MaxPoints=239.7436
INSERTING Routine Maintenance - IPNW Area=nwspw Achieved=100 Nodes=7 MaxPoints=98.7179
INSERTING Routine Maintenance - IPNW Area=nwuva Achieved=50.0 Nodes=8 MaxPoints=112.8205
INSERTING Routine Maintenance - IPNW Area=nwwpc1 Achieved=100 Nodes=9 MaxPoints=126.9231
INSERTING Routine Maintenance - IPNW Area=nwwpc2 Achieved=0 Nodes=39 MaxPoints=550.0000
INSERTING Routine Maintenance - IPNW Area=nwwpe Achieved=100 Nodes=14 MaxPoints=197.4359
INSERTING Routine Maintenance - IPNW Area=nwwpn Achieved=100 Nodes=15 MaxPoints=211.5385
INSERTING Routine Maintenance - IPNW Area=nwwpne Achieved=100 Nodes=14 MaxPoints=197.4359
INSERTING Routine Maintenance - IPNW Area=nwwps Achieved=100 Nodes=9 MaxPoints=126.9231
INSERTING Routine Maintenance - IPNW Area=nwwpse Achieved=28.57 Nodes=7 MaxPoints=98.7179
INSERTING Routine Maintenance - IPNW Area=nwwpsw Achieved=100 Nodes=13 MaxPoints=183.3333
ENTERED SLBN BLOCK
INSERTING Routine Maintenance - SLBN/SDH Area=nwcpn Achieved=100 Nodes=4 MaxPoints=165.00
INSERTING Routine Maintenance - SLBN/SDH Area=nwcps Achieved=100 Nodes=3 MaxPoints=123.7500
INSERTING Routine Maintenance - SLBN/SDH Area=nwep Achieved=100 Nodes=4 MaxPoints=165.00
INSERTING Routine Maintenance - SLBN/SDH Area=nwncp Achieved=100 Nodes=7 MaxPoints=288.7500
INSERTING Routine Maintenance - SLBN/SDH Area=nwnp1 Achieved=100 Nodes=1 MaxPoints=41.2500
INSERTING Routine Maintenance - SLBN/SDH Area=nwnp2 Achieved=100 Nodes=8 MaxPoints=330.0
INSERTING Routine Maintenance - SLBN/SDH Area=nwnwpe Achieved=100 Nodes=3 MaxPoints=123.7500
INSERTING Routine Maintenance - SLBN/SDH Area=nwnwpw Achieved=100 Nodes=1 MaxPoints=41.2500
INSERTING Routine Maintenance - SLBN/SDH Area=nwsab Achieved=100 Nodes=6 MaxPoints=247.500
INSERTING Routine Maintenance - SLBN/SDH Area=nwspe Achieved=100 Nodes=5 MaxPoints=206.2500
INSERTING Routine Maintenance - SLBN/SDH Area=nwspw Achieved=100 Nodes=2 MaxPoints=82.500
INSERTING Routine Maintenance - SLBN/SDH Area=nwuva Achieved=100 Nodes=3 MaxPoints=123.7500
INSERTING Routine Maintenance - SLBN/SDH Area=nwwpc1 Achieved=100 Nodes=2 MaxPoints=82.500
INSERTING Routine Maintenance - SLBN/SDH Area=nwwpc2 Achieved=0 Nodes=4 MaxPoints=165.00
INSERTING Routine Maintenance - SLBN/SDH Area=nwwpe Achieved=100 Nodes=4 MaxPoints=165.00
INSERTING Routine Maintenance - SLBN/SDH Area=nwwpn Achieved=100 Nodes=7 MaxPoints=288.7500
INSERTING Routine Maintenance - SLBN/SDH Area=nwwpne Achieved=100 Nodes=5 MaxPoints=206.2500
INSERTING Routine Maintenance - SLBN/SDH Area=nwwps Achieved=100 Nodes=3 MaxPoints=123.7500
INSERTING Routine Maintenance - SLBN/SDH Area=nwwpse Achieved=66.67 Nodes=3 MaxPoints=123.7500
INSERTING Routine Maintenance - SLBN/SDH Area=nwwpsw Achieved=100 Nodes=5 MaxPoints=206.2500
ENTERED MSAN BLOCK
INSERTING Routine Maintenance - MSAN/OLTE Area=nwcpn Achieved=99.75 Nodes=394 MaxPoints=223.3877
INSERTING Routine Maintenance - MSAN/OLTE Area=nwcps Achieved=14.35 Nodes=230 MaxPoints=130.4040
INSERTING Routine Maintenance - MSAN/OLTE Area=nwep Achieved=100 Nodes=185 MaxPoints=104.8901
INSERTING Routine Maintenance - MSAN/OLTE Area=nwncp Achieved=100 Nodes=160 MaxPoints=90.7158
INSERTING Routine Maintenance - MSAN/OLTE Area=nwnp1 Achieved=100 Nodes=144 MaxPoints=81.6442
INSERTING Routine Maintenance - MSAN/OLTE Area=nwnp2 Achieved=89.20 Nodes=176 MaxPoints=99.7874
INSERTING Routine Maintenance - MSAN/OLTE Area=nwnwpe Achieved=100 Nodes=180 MaxPoints=102.0553
INSERTING Routine Maintenance - MSAN/OLTE Area=nwnwpw Achieved=100 Nodes=120 MaxPoints=68.0369
INSERTING Routine Maintenance - MSAN/OLTE Area=nwsab Achieved=70.45 Nodes=264 MaxPoints=149.6811
INSERTING Routine Maintenance - MSAN/OLTE Area=nwspe Achieved=100 Nodes=224 MaxPoints=127.0021
INSERTING Routine Maintenance - MSAN/OLTE Area=nwspw Achieved=89.43 Nodes=123 MaxPoints=69.7378
INSERTING Routine Maintenance - MSAN/OLTE Area=nwuva Achieved=91.33 Nodes=150 MaxPoints=85.0461
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwpc1 Achieved=100 Nodes=96 MaxPoints=54.4295
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwpc2 Achieved=0 Nodes=148 MaxPoints=83.9121
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwpe Achieved=32.75 Nodes=284 MaxPoints=161.0206
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwpn Achieved=51.03 Nodes=292 MaxPoints=165.5563
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwpne Achieved=92.28 Nodes=311 MaxPoints=176.3288
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwps Achieved=89.80 Nodes=294 MaxPoints=166.6903
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwpse Achieved=18.72 Nodes=203 MaxPoints=115.0957
INSERTING Routine Maintenance - MSAN/OLTE Area=nwwpsw Achieved=100 Nodes=255 MaxPoints=144.5783
ENTERED TOWER BLOCK
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwcpn Achieved=100 Nodes=8 MaxPoints=80.8081
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwcps Achieved=80.0 Nodes=10 MaxPoints=101.0101
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwep Achieved=100 Nodes=5 MaxPoints=50.5051
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwncp Achieved=100 Nodes=9 MaxPoints=90.9091
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwnp1 Achieved=100 Nodes=4 MaxPoints=40.4040
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwnp2 Achieved=50.0 Nodes=10 MaxPoints=101.0101
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwnwpe Achieved=100 Nodes=4 MaxPoints=40.4040
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwnwpw Achieved=100 Nodes=3 MaxPoints=30.3030
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwsab Achieved=100 Nodes=4 MaxPoints=40.4040
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwspe Achieved=90.0 Nodes=10 MaxPoints=101.0101
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwspw Achieved=83.33 Nodes=6 MaxPoints=60.6061
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwuva Achieved=100 Nodes=7 MaxPoints=70.7071
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwpc1 Achieved=66.67 Nodes=3 MaxPoints=30.3030
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwpc2 Achieved=0 Nodes=1 MaxPoints=10.1010
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwpe Achieved=100 Nodes=2 MaxPoints=20.2020
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwpn Achieved=25.00 Nodes=4 MaxPoints=40.4040
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwpne Achieved=100 Nodes=4 MaxPoints=40.4040
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwps Achieved=50.0 Nodes=2 MaxPoints=20.2020
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwpse Achieved=0 Nodes=2 MaxPoints=20.2020
INSERTING Operation & Maintenance of SLT towers and tower premises Area=nwwpsw Achieved=0 Nodes=1 MaxPoints=10.1010
ENTERED POWER & AC BLOCK
INSERTING O&M of Power & Aircondition Area=nwcpn Achieved=100 Nodes=13 MaxPoints=277.7778
INSERTING O&M of Power & Aircondition Area=nwcps Achieved=100 Nodes=12 MaxPoints=256.4103
INSERTING O&M of Power & Aircondition Area=nwep Achieved=87.50 Nodes=8 MaxPoints=170.9402
INSERTING O&M of Power & Aircondition Area=nwncp Achieved=91.67 Nodes=12 MaxPoints=256.4103
INSERTING O&M of Power & Aircondition Area=nwnp1 Achieved=100 Nodes=3 MaxPoints=64.1026
INSERTING O&M of Power & Aircondition Area=nwnp2 Achieved=42.86 Nodes=7 MaxPoints=149.5726
INSERTING O&M of Power & Aircondition Area=nwnwpe Achieved=10.0 Nodes=10 MaxPoints=213.6752
INSERTING O&M of Power & Aircondition Area=nwnwpw Achieved=60.0 Nodes=5 MaxPoints=106.8376
INSERTING O&M of Power & Aircondition Area=nwsab Achieved=100 Nodes=12 MaxPoints=256.4103
INSERTING O&M of Power & Aircondition Area=nwspe Achieved=88.24 Nodes=17 MaxPoints=363.2479
INSERTING O&M of Power & Aircondition Area=nwspw Achieved=100 Nodes=7 MaxPoints=149.5726
INSERTING O&M of Power & Aircondition Area=nwuva Achieved=50.0 Nodes=8 MaxPoints=170.9402
INSERTING O&M of Power & Aircondition Area=nwwpc1 Achieved=100 Nodes=9 MaxPoints=192.3077
INSERTING O&M of Power & Aircondition Area=nwwpc2 Achieved=0 Nodes=39 MaxPoints=833.3333
INSERTING O&M of Power & Aircondition Area=nwwpe Achieved=100 Nodes=14 MaxPoints=299.1453
INSERTING O&M of Power & Aircondition Area=nwwpn Achieved=100 Nodes=15 MaxPoints=320.5128
INSERTING O&M of Power & Aircondition Area=nwwpne Achieved=100 Nodes=14 MaxPoints=299.1453
INSERTING O&M of Power & Aircondition Area=nwwps Achieved=100 Nodes=9 MaxPoints=192.3077
INSERTING O&M of Power & Aircondition Area=nwwpse Achieved=28.57 Nodes=7 MaxPoints=149.5726
INSERTING O&M of Power & Aircondition Area=nwwpsw Achieved=100 Nodes=13 MaxPoints=277.7778
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@__month_0='?' (Size = 1) (DbType = Byte), @__year_1='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], [o].[AchievedValue], [o].[AreaCode], [o].[CalculatedAt], [o].[KpiCode], [o].[KpiDefinitionId], [o].[KpiName], [o].[PointsApplicable], [o].[Month], [o].[OverallKpiValuePercent], [o].[Platform], [o].[PointsAchieved], [o].[TargetValue], [o].[Year]
      FROM [dbo].[OverallKpiResult] AS [o]
      WHERE [o].[Month] = @__month_0 AND [o].[Year] = @__year_1
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (40ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (2ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (DbType = Int32), @p24='?' (DbType = Int32), @p25='?' (DbType = Int32), @p26='?' (DbType = Int32), @p27='?' (DbType = Int32), @p28='?' (DbType = Int32), @p29='?' (DbType = Int32), @p30='?' (DbType = Int32), @p31='?' (DbType = Int32), @p32='?' (DbType = Int32), @p33='?' (DbType = Int32), @p34='?' (DbType = Int32), @p35='?' (DbType = Int32), @p36='?' (DbType = Int32), @p37='?' (DbType = Int32), @p38='?' (DbType = Int32), @p39='?' (DbType = Int32), @p40='?' (DbType = Int32), @p41='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p23;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p24;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p25;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p26;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p27;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p28;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p29;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p30;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p31;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p32;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p33;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p34;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p35;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p36;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p37;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p38;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p39;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p40;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p41;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (45ms) [Parameters=[@p0='?' (DbType = Int32), @p1='?' (DbType = Int32), @p2='?' (DbType = Int32), @p3='?' (DbType = Int32), @p4='?' (DbType = Int32), @p5='?' (DbType = Int32), @p6='?' (DbType = Int32), @p7='?' (DbType = Int32), @p8='?' (DbType = Int32), @p9='?' (DbType = Int32), @p10='?' (DbType = Int32), @p11='?' (DbType = Int32), @p12='?' (DbType = Int32), @p13='?' (DbType = Int32), @p14='?' (DbType = Int32), @p15='?' (DbType = Int32), @p16='?' (DbType = Int32), @p17='?' (DbType = Int32), @p18='?' (DbType = Int32), @p19='?' (DbType = Int32), @p20='?' (DbType = Int32), @p21='?' (DbType = Int32), @p22='?' (DbType = Int32), @p23='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p24='?' (Size = 50), @p25='?' (DbType = DateTime2), @p26='?' (Size = 50), @p27='?' (DbType = Int32), @p28='?' (Size = 255), @p29='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p30='?' (Size = 1) (DbType = Byte), @p31='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p32='?' (Size = 100), @p33='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p34='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p35='?' (DbType = Int16), @p36='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p37='?' (Size = 50), @p38='?' (DbType = DateTime2), @p39='?' (Size = 50), @p40='?' (DbType = Int32), @p41='?' (Size = 255), @p42='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p43='?' (Size = 1) (DbType = Byte), @p44='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p45='?' (Size = 100), @p46='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p47='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p48='?' (DbType = Int16), @p49='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p50='?' (Size = 50), @p51='?' (DbType = DateTime2), @p52='?' (Size = 50), @p53='?' (DbType = Int32), @p54='?' (Size = 255), @p55='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p56='?' (Size = 1) (DbType = Byte), @p57='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p58='?' (Size = 100), @p59='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p60='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p61='?' (DbType = Int16), @p62='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p63='?' (Size = 50), @p64='?' (DbType = DateTime2), @p65='?' (Size = 50), @p66='?' (DbType = Int32), @p67='?' (Size = 255), @p68='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p69='?' (Size = 1) (DbType = Byte), @p70='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p71='?' (Size = 100), @p72='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p73='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p74='?' (DbType = Int16), @p75='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p76='?' (Size = 50), @p77='?' (DbType = DateTime2), @p78='?' (Size = 50), @p79='?' (DbType = Int32), @p80='?' (Size = 255), @p81='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p82='?' (Size = 1) (DbType = Byte), @p83='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p84='?' (Size = 100), @p85='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p86='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p87='?' (DbType = Int16), @p88='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p89='?' (Size = 50), @p90='?' (DbType = DateTime2), @p91='?' (Size = 50), @p92='?' (DbType = Int32), @p93='?' (Size = 255), @p94='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p95='?' (Size = 1) (DbType = Byte), @p96='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p97='?' (Size = 100), @p98='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p99='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p100='?' (DbType = Int16), @p101='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p102='?' (Size = 50), @p103='?' (DbType = DateTime2), @p104='?' (Size = 50), @p105='?' (DbType = Int32), @p106='?' (Size = 255), @p107='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p108='?' (Size = 1) (DbType = Byte), @p109='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p110='?' (Size = 100), @p111='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p112='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p113='?' (DbType = Int16), @p114='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p115='?' (Size = 50), @p116='?' (DbType = DateTime2), @p117='?' (Size = 50), @p118='?' (DbType = Int32), @p119='?' (Size = 255), @p120='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p121='?' (Size = 1) (DbType = Byte), @p122='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p123='?' (Size = 100), @p124='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p125='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p126='?' (DbType = Int16), @p127='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p128='?' (Size = 50), @p129='?' (DbType = DateTime2), @p130='?' (Size = 50), @p131='?' (DbType = Int32), @p132='?' (Size = 255), @p133='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p134='?' (Size = 1) (DbType = Byte), @p135='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p136='?' (Size = 100), @p137='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p138='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p139='?' (DbType = Int16), @p140='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p141='?' (Size = 50), @p142='?' (DbType = DateTime2), @p143='?' (Size = 50), @p144='?' (DbType = Int32), @p145='?' (Size = 255), @p146='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p147='?' (Size = 1) (DbType = Byte), @p148='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p149='?' (Size = 100), @p150='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p151='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p152='?' (DbType = Int16), @p153='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p154='?' (Size = 50), @p155='?' (DbType = DateTime2), @p156='?' (Size = 50), @p157='?' (DbType = Int32), @p158='?' (Size = 255), @p159='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p160='?' (Size = 1) (DbType = Byte), @p161='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p162='?' (Size = 100), @p163='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p164='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p165='?' (DbType = Int16), @p166='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p167='?' (Size = 50), @p168='?' (DbType = DateTime2), @p169='?' (Size = 50), @p170='?' (DbType = Int32), @p171='?' (Size = 255), @p172='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p173='?' (Size = 1) (DbType = Byte), @p174='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p175='?' (Size = 100), @p176='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p177='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p178='?' (DbType = Int16), @p179='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p180='?' (Size = 50), @p181='?' (DbType = DateTime2), @p182='?' (Size = 50), @p183='?' (DbType = Int32), @p184='?' (Size = 255), @p185='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p186='?' (Size = 1) (DbType = Byte), @p187='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p188='?' (Size = 100), @p189='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p190='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p191='?' (DbType = Int16), @p192='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p193='?' (Size = 50), @p194='?' (DbType = DateTime2), @p195='?' (Size = 50), @p196='?' (DbType = Int32), @p197='?' (Size = 255), @p198='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p199='?' (Size = 1) (DbType = Byte), @p200='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p201='?' (Size = 100), @p202='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p203='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p204='?' (DbType = Int16), @p205='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p206='?' (Size = 50), @p207='?' (DbType = DateTime2), @p208='?' (Size = 50), @p209='?' (DbType = Int32), @p210='?' (Size = 255), @p211='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p212='?' (Size = 1) (DbType = Byte), @p213='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p214='?' (Size = 100), @p215='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p216='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p217='?' (DbType = Int16), @p218='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p219='?' (Size = 50), @p220='?' (DbType = DateTime2), @p221='?' (Size = 50), @p222='?' (DbType = Int32), @p223='?' (Size = 255), @p224='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p225='?' (Size = 1) (DbType = Byte), @p226='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p227='?' (Size = 100), @p228='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p229='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p230='?' (DbType = Int16), @p231='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p232='?' (Size = 50), @p233='?' (DbType = DateTime2), @p234='?' (Size = 50), @p235='?' (DbType = Int32), @p236='?' (Size = 255), @p237='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p238='?' (Size = 1) (DbType = Byte), @p239='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p240='?' (Size = 100), @p241='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p242='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p243='?' (DbType = Int16), @p244='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p245='?' (Size = 50), @p246='?' (DbType = DateTime2), @p247='?' (Size = 50), @p248='?' (DbType = Int32), @p249='?' (Size = 255), @p250='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p251='?' (Size = 1) (DbType = Byte), @p252='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p253='?' (Size = 100), @p254='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p255='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p256='?' (DbType = Int16), @p257='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p258='?' (Size = 50), @p259='?' (DbType = DateTime2), @p260='?' (Size = 50), @p261='?' (DbType = Int32), @p262='?' (Size = 255), @p263='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p264='?' (Size = 1) (DbType = Byte), @p265='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p266='?' (Size = 100), @p267='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p268='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p269='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET NOCOUNT ON;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p0;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p1;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p2;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p3;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p4;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p5;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p6;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p7;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p8;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p9;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p10;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p11;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p12;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p13;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p14;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p15;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p16;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p17;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p18;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p19;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p20;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p21;
      DELETE FROM [dbo].[OverallKpiResult]
      OUTPUT 1
      WHERE [Id] = @p22;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, 0),
      (@p36, @p37, @p38, @p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, 1),
      (@p49, @p50, @p51, @p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, 2),
      (@p62, @p63, @p64, @p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, 3),
      (@p75, @p76, @p77, @p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, 4),
      (@p88, @p89, @p90, @p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, 5),
      (@p101, @p102, @p103, @p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, 6),
      (@p114, @p115, @p116, @p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, 7),
      (@p127, @p128, @p129, @p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, 8),
      (@p140, @p141, @p142, @p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, 9),
      (@p153, @p154, @p155, @p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, 10),
      (@p166, @p167, @p168, @p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, 11),
      (@p179, @p180, @p181, @p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, 12),
      (@p192, @p193, @p194, @p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, 13),
      (@p205, @p206, @p207, @p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, 14),
      (@p218, @p219, @p220, @p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, 15),
      (@p231, @p232, @p233, @p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, 16),
      (@p244, @p245, @p246, @p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, 17),
      (@p257, @p258, @p259, @p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, 18)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (33ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (6ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (5ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (5ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (4ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16), @p52='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p53='?' (Size = 50), @p54='?' (DbType = DateTime2), @p55='?' (Size = 50), @p56='?' (DbType = Int32), @p57='?' (Size = 255), @p58='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p59='?' (Size = 1) (DbType = Byte), @p60='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p61='?' (Size = 100), @p62='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p63='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p64='?' (DbType = Int16), @p65='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p66='?' (Size = 50), @p67='?' (DbType = DateTime2), @p68='?' (Size = 50), @p69='?' (DbType = Int32), @p70='?' (Size = 255), @p71='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p72='?' (Size = 1) (DbType = Byte), @p73='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p74='?' (Size = 100), @p75='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p76='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p77='?' (DbType = Int16), @p78='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p79='?' (Size = 50), @p80='?' (DbType = DateTime2), @p81='?' (Size = 50), @p82='?' (DbType = Int32), @p83='?' (Size = 255), @p84='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p85='?' (Size = 1) (DbType = Byte), @p86='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p87='?' (Size = 100), @p88='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p89='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p90='?' (DbType = Int16), @p91='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p92='?' (Size = 50), @p93='?' (DbType = DateTime2), @p94='?' (Size = 50), @p95='?' (DbType = Int32), @p96='?' (Size = 255), @p97='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p98='?' (Size = 1) (DbType = Byte), @p99='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p100='?' (Size = 100), @p101='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p102='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p103='?' (DbType = Int16), @p104='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p105='?' (Size = 50), @p106='?' (DbType = DateTime2), @p107='?' (Size = 50), @p108='?' (DbType = Int32), @p109='?' (Size = 255), @p110='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p111='?' (Size = 1) (DbType = Byte), @p112='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p113='?' (Size = 100), @p114='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p115='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p116='?' (DbType = Int16), @p117='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p118='?' (Size = 50), @p119='?' (DbType = DateTime2), @p120='?' (Size = 50), @p121='?' (DbType = Int32), @p122='?' (Size = 255), @p123='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p124='?' (Size = 1) (DbType = Byte), @p125='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p126='?' (Size = 100), @p127='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p128='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p129='?' (DbType = Int16), @p130='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p131='?' (Size = 50), @p132='?' (DbType = DateTime2), @p133='?' (Size = 50), @p134='?' (DbType = Int32), @p135='?' (Size = 255), @p136='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p137='?' (Size = 1) (DbType = Byte), @p138='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p139='?' (Size = 100), @p140='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p141='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p142='?' (DbType = Int16), @p143='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p144='?' (Size = 50), @p145='?' (DbType = DateTime2), @p146='?' (Size = 50), @p147='?' (DbType = Int32), @p148='?' (Size = 255), @p149='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p150='?' (Size = 1) (DbType = Byte), @p151='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p152='?' (Size = 100), @p153='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p154='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p155='?' (DbType = Int16), @p156='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p157='?' (Size = 50), @p158='?' (DbType = DateTime2), @p159='?' (Size = 50), @p160='?' (DbType = Int32), @p161='?' (Size = 255), @p162='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p163='?' (Size = 1) (DbType = Byte), @p164='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p165='?' (Size = 100), @p166='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p167='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p168='?' (DbType = Int16), @p169='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p170='?' (Size = 50), @p171='?' (DbType = DateTime2), @p172='?' (Size = 50), @p173='?' (DbType = Int32), @p174='?' (Size = 255), @p175='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p176='?' (Size = 1) (DbType = Byte), @p177='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p178='?' (Size = 100), @p179='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p180='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p181='?' (DbType = Int16), @p182='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p183='?' (Size = 50), @p184='?' (DbType = DateTime2), @p185='?' (Size = 50), @p186='?' (DbType = Int32), @p187='?' (Size = 255), @p188='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p189='?' (Size = 1) (DbType = Byte), @p190='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p191='?' (Size = 100), @p192='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p193='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p194='?' (DbType = Int16), @p195='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p196='?' (Size = 50), @p197='?' (DbType = DateTime2), @p198='?' (Size = 50), @p199='?' (DbType = Int32), @p200='?' (Size = 255), @p201='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p202='?' (Size = 1) (DbType = Byte), @p203='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p204='?' (Size = 100), @p205='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p206='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p207='?' (DbType = Int16), @p208='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p209='?' (Size = 50), @p210='?' (DbType = DateTime2), @p211='?' (Size = 50), @p212='?' (DbType = Int32), @p213='?' (Size = 255), @p214='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p215='?' (Size = 1) (DbType = Byte), @p216='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p217='?' (Size = 100), @p218='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p219='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p220='?' (DbType = Int16), @p221='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p222='?' (Size = 50), @p223='?' (DbType = DateTime2), @p224='?' (Size = 50), @p225='?' (DbType = Int32), @p226='?' (Size = 255), @p227='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p228='?' (Size = 1) (DbType = Byte), @p229='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p230='?' (Size = 100), @p231='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p232='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p233='?' (DbType = Int16), @p234='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p235='?' (Size = 50), @p236='?' (DbType = DateTime2), @p237='?' (Size = 50), @p238='?' (DbType = Int32), @p239='?' (Size = 255), @p240='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p241='?' (Size = 1) (DbType = Byte), @p242='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p243='?' (Size = 100), @p244='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p245='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p246='?' (DbType = Int16), @p247='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p248='?' (Size = 50), @p249='?' (DbType = DateTime2), @p250='?' (Size = 50), @p251='?' (DbType = Int32), @p252='?' (Size = 255), @p253='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p254='?' (Size = 1) (DbType = Byte), @p255='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p256='?' (Size = 100), @p257='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p258='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p259='?' (DbType = Int16), @p260='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p261='?' (Size = 50), @p262='?' (DbType = DateTime2), @p263='?' (Size = 50), @p264='?' (DbType = Int32), @p265='?' (Size = 255), @p266='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p267='?' (Size = 1) (DbType = Byte), @p268='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p269='?' (Size = 100), @p270='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p271='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p272='?' (DbType = Int16), @p273='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p274='?' (Size = 50), @p275='?' (DbType = DateTime2), @p276='?' (Size = 50), @p277='?' (DbType = Int32), @p278='?' (Size = 255), @p279='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p280='?' (Size = 1) (DbType = Byte), @p281='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p282='?' (Size = 100), @p283='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p284='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p285='?' (DbType = Int16), @p286='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p287='?' (Size = 50), @p288='?' (DbType = DateTime2), @p289='?' (Size = 50), @p290='?' (DbType = Int32), @p291='?' (Size = 255), @p292='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p293='?' (Size = 1) (DbType = Byte), @p294='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p295='?' (Size = 100), @p296='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p297='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p298='?' (DbType = Int16), @p299='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p300='?' (Size = 50), @p301='?' (DbType = DateTime2), @p302='?' (Size = 50), @p303='?' (DbType = Int32), @p304='?' (Size = 255), @p305='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p306='?' (Size = 1) (DbType = Byte), @p307='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p308='?' (Size = 100), @p309='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p310='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p311='?' (DbType = Int16), @p312='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p313='?' (Size = 50), @p314='?' (DbType = DateTime2), @p315='?' (Size = 50), @p316='?' (DbType = Int32), @p317='?' (Size = 255), @p318='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p319='?' (Size = 1) (DbType = Byte), @p320='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p321='?' (Size = 100), @p322='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p323='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p324='?' (DbType = Int16), @p325='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p326='?' (Size = 50), @p327='?' (DbType = DateTime2), @p328='?' (Size = 50), @p329='?' (DbType = Int32), @p330='?' (Size = 255), @p331='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p332='?' (Size = 1) (DbType = Byte), @p333='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p334='?' (Size = 100), @p335='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p336='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p337='?' (DbType = Int16), @p338='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p339='?' (Size = 50), @p340='?' (DbType = DateTime2), @p341='?' (Size = 50), @p342='?' (DbType = Int32), @p343='?' (Size = 255), @p344='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p345='?' (Size = 1) (DbType = Byte), @p346='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p347='?' (Size = 100), @p348='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p349='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p350='?' (DbType = Int16), @p351='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p352='?' (Size = 50), @p353='?' (DbType = DateTime2), @p354='?' (Size = 50), @p355='?' (DbType = Int32), @p356='?' (Size = 255), @p357='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p358='?' (Size = 1) (DbType = Byte), @p359='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p360='?' (Size = 100), @p361='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p362='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p363='?' (DbType = Int16), @p364='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p365='?' (Size = 50), @p366='?' (DbType = DateTime2), @p367='?' (Size = 50), @p368='?' (DbType = Int32), @p369='?' (Size = 255), @p370='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p371='?' (Size = 1) (DbType = Byte), @p372='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p373='?' (Size = 100), @p374='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p375='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p376='?' (DbType = Int16), @p377='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p378='?' (Size = 50), @p379='?' (DbType = DateTime2), @p380='?' (Size = 50), @p381='?' (DbType = Int32), @p382='?' (Size = 255), @p383='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p384='?' (Size = 1) (DbType = Byte), @p385='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p386='?' (Size = 100), @p387='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p388='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p389='?' (DbType = Int16), @p390='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p391='?' (Size = 50), @p392='?' (DbType = DateTime2), @p393='?' (Size = 50), @p394='?' (DbType = Int32), @p395='?' (Size = 255), @p396='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p397='?' (Size = 1) (DbType = Byte), @p398='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p399='?' (Size = 100), @p400='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p401='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p402='?' (DbType = Int16), @p403='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p404='?' (Size = 50), @p405='?' (DbType = DateTime2), @p406='?' (Size = 50), @p407='?' (DbType = Int32), @p408='?' (Size = 255), @p409='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p410='?' (Size = 1) (DbType = Byte), @p411='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p412='?' (Size = 100), @p413='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p414='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p415='?' (DbType = Int16), @p416='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p417='?' (Size = 50), @p418='?' (DbType = DateTime2), @p419='?' (Size = 50), @p420='?' (DbType = Int32), @p421='?' (Size = 255), @p422='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p423='?' (Size = 1) (DbType = Byte), @p424='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p425='?' (Size = 100), @p426='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p427='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p428='?' (DbType = Int16), @p429='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p430='?' (Size = 50), @p431='?' (DbType = DateTime2), @p432='?' (Size = 50), @p433='?' (DbType = Int32), @p434='?' (Size = 255), @p435='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p436='?' (Size = 1) (DbType = Byte), @p437='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p438='?' (Size = 100), @p439='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p440='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p441='?' (DbType = Int16), @p442='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p443='?' (Size = 50), @p444='?' (DbType = DateTime2), @p445='?' (Size = 50), @p446='?' (DbType = Int32), @p447='?' (Size = 255), @p448='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p449='?' (Size = 1) (DbType = Byte), @p450='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p451='?' (Size = 100), @p452='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p453='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p454='?' (DbType = Int16), @p455='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p456='?' (Size = 50), @p457='?' (DbType = DateTime2), @p458='?' (Size = 50), @p459='?' (DbType = Int32), @p460='?' (Size = 255), @p461='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p462='?' (Size = 1) (DbType = Byte), @p463='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p464='?' (Size = 100), @p465='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p466='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p467='?' (DbType = Int16), @p468='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p469='?' (Size = 50), @p470='?' (DbType = DateTime2), @p471='?' (Size = 50), @p472='?' (DbType = Int32), @p473='?' (Size = 255), @p474='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p475='?' (Size = 1) (DbType = Byte), @p476='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p477='?' (Size = 100), @p478='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p479='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p480='?' (DbType = Int16), @p481='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p482='?' (Size = 50), @p483='?' (DbType = DateTime2), @p484='?' (Size = 50), @p485='?' (DbType = Int32), @p486='?' (Size = 255), @p487='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p488='?' (Size = 1) (DbType = Byte), @p489='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p490='?' (Size = 100), @p491='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p492='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p493='?' (DbType = Int16), @p494='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p495='?' (Size = 50), @p496='?' (DbType = DateTime2), @p497='?' (Size = 50), @p498='?' (DbType = Int32), @p499='?' (Size = 255), @p500='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p501='?' (Size = 1) (DbType = Byte), @p502='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p503='?' (Size = 100), @p504='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p505='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p506='?' (DbType = Int16), @p507='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p508='?' (Size = 50), @p509='?' (DbType = DateTime2), @p510='?' (Size = 50), @p511='?' (DbType = Int32), @p512='?' (Size = 255), @p513='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p514='?' (Size = 1) (DbType = Byte), @p515='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p516='?' (Size = 100), @p517='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p518='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p519='?' (DbType = Int16), @p520='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p521='?' (Size = 50), @p522='?' (DbType = DateTime2), @p523='?' (Size = 50), @p524='?' (DbType = Int32), @p525='?' (Size = 255), @p526='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p527='?' (Size = 1) (DbType = Byte), @p528='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p529='?' (Size = 100), @p530='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p531='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p532='?' (DbType = Int16), @p533='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p534='?' (Size = 50), @p535='?' (DbType = DateTime2), @p536='?' (Size = 50), @p537='?' (DbType = Int32), @p538='?' (Size = 255), @p539='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p540='?' (Size = 1) (DbType = Byte), @p541='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p542='?' (Size = 100), @p543='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p544='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p545='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3),
      (@p52, @p53, @p54, @p55, @p56, @p57, @p58, @p59, @p60, @p61, @p62, @p63, @p64, 4),
      (@p65, @p66, @p67, @p68, @p69, @p70, @p71, @p72, @p73, @p74, @p75, @p76, @p77, 5),
      (@p78, @p79, @p80, @p81, @p82, @p83, @p84, @p85, @p86, @p87, @p88, @p89, @p90, 6),
      (@p91, @p92, @p93, @p94, @p95, @p96, @p97, @p98, @p99, @p100, @p101, @p102, @p103, 7),
      (@p104, @p105, @p106, @p107, @p108, @p109, @p110, @p111, @p112, @p113, @p114, @p115, @p116, 8),
      (@p117, @p118, @p119, @p120, @p121, @p122, @p123, @p124, @p125, @p126, @p127, @p128, @p129, 9),
      (@p130, @p131, @p132, @p133, @p134, @p135, @p136, @p137, @p138, @p139, @p140, @p141, @p142, 10),
      (@p143, @p144, @p145, @p146, @p147, @p148, @p149, @p150, @p151, @p152, @p153, @p154, @p155, 11),
      (@p156, @p157, @p158, @p159, @p160, @p161, @p162, @p163, @p164, @p165, @p166, @p167, @p168, 12),
      (@p169, @p170, @p171, @p172, @p173, @p174, @p175, @p176, @p177, @p178, @p179, @p180, @p181, 13),
      (@p182, @p183, @p184, @p185, @p186, @p187, @p188, @p189, @p190, @p191, @p192, @p193, @p194, 14),
      (@p195, @p196, @p197, @p198, @p199, @p200, @p201, @p202, @p203, @p204, @p205, @p206, @p207, 15),
      (@p208, @p209, @p210, @p211, @p212, @p213, @p214, @p215, @p216, @p217, @p218, @p219, @p220, 16),
      (@p221, @p222, @p223, @p224, @p225, @p226, @p227, @p228, @p229, @p230, @p231, @p232, @p233, 17),
      (@p234, @p235, @p236, @p237, @p238, @p239, @p240, @p241, @p242, @p243, @p244, @p245, @p246, 18),
      (@p247, @p248, @p249, @p250, @p251, @p252, @p253, @p254, @p255, @p256, @p257, @p258, @p259, 19),
      (@p260, @p261, @p262, @p263, @p264, @p265, @p266, @p267, @p268, @p269, @p270, @p271, @p272, 20),
      (@p273, @p274, @p275, @p276, @p277, @p278, @p279, @p280, @p281, @p282, @p283, @p284, @p285, 21),
      (@p286, @p287, @p288, @p289, @p290, @p291, @p292, @p293, @p294, @p295, @p296, @p297, @p298, 22),
      (@p299, @p300, @p301, @p302, @p303, @p304, @p305, @p306, @p307, @p308, @p309, @p310, @p311, 23),
      (@p312, @p313, @p314, @p315, @p316, @p317, @p318, @p319, @p320, @p321, @p322, @p323, @p324, 24),
      (@p325, @p326, @p327, @p328, @p329, @p330, @p331, @p332, @p333, @p334, @p335, @p336, @p337, 25),
      (@p338, @p339, @p340, @p341, @p342, @p343, @p344, @p345, @p346, @p347, @p348, @p349, @p350, 26),
      (@p351, @p352, @p353, @p354, @p355, @p356, @p357, @p358, @p359, @p360, @p361, @p362, @p363, 27),
      (@p364, @p365, @p366, @p367, @p368, @p369, @p370, @p371, @p372, @p373, @p374, @p375, @p376, 28),
      (@p377, @p378, @p379, @p380, @p381, @p382, @p383, @p384, @p385, @p386, @p387, @p388, @p389, 29),
      (@p390, @p391, @p392, @p393, @p394, @p395, @p396, @p397, @p398, @p399, @p400, @p401, @p402, 30),
      (@p403, @p404, @p405, @p406, @p407, @p408, @p409, @p410, @p411, @p412, @p413, @p414, @p415, 31),
      (@p416, @p417, @p418, @p419, @p420, @p421, @p422, @p423, @p424, @p425, @p426, @p427, @p428, 32),
      (@p429, @p430, @p431, @p432, @p433, @p434, @p435, @p436, @p437, @p438, @p439, @p440, @p441, 33),
      (@p442, @p443, @p444, @p445, @p446, @p447, @p448, @p449, @p450, @p451, @p452, @p453, @p454, 34),
      (@p455, @p456, @p457, @p458, @p459, @p460, @p461, @p462, @p463, @p464, @p465, @p466, @p467, 35),
      (@p468, @p469, @p470, @p471, @p472, @p473, @p474, @p475, @p476, @p477, @p478, @p479, @p480, 36),
      (@p481, @p482, @p483, @p484, @p485, @p486, @p487, @p488, @p489, @p490, @p491, @p492, @p493, 37),
      (@p494, @p495, @p496, @p497, @p498, @p499, @p500, @p501, @p502, @p503, @p504, @p505, @p506, 38),
      (@p507, @p508, @p509, @p510, @p511, @p512, @p513, @p514, @p515, @p516, @p517, @p518, @p519, 39),
      (@p520, @p521, @p522, @p523, @p524, @p525, @p526, @p527, @p528, @p529, @p530, @p531, @p532, 40),
      (@p533, @p534, @p535, @p536, @p537, @p538, @p539, @p540, @p541, @p542, @p543, @p544, @p545, 41)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (10ms) [Parameters=[@p0='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p1='?' (Size = 50), @p2='?' (DbType = DateTime2), @p3='?' (Size = 50), @p4='?' (DbType = Int32), @p5='?' (Size = 255), @p6='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p7='?' (Size = 1) (DbType = Byte), @p8='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p9='?' (Size = 100), @p10='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p11='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p12='?' (DbType = Int16), @p13='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p14='?' (Size = 50), @p15='?' (DbType = DateTime2), @p16='?' (Size = 50), @p17='?' (DbType = Int32), @p18='?' (Size = 255), @p19='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p20='?' (Size = 1) (DbType = Byte), @p21='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p22='?' (Size = 100), @p23='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p24='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p25='?' (DbType = Int16), @p26='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p27='?' (Size = 50), @p28='?' (DbType = DateTime2), @p29='?' (Size = 50), @p30='?' (DbType = Int32), @p31='?' (Size = 255), @p32='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p33='?' (Size = 1) (DbType = Byte), @p34='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p35='?' (Size = 100), @p36='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p37='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p38='?' (DbType = Int16), @p39='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p40='?' (Size = 50), @p41='?' (DbType = DateTime2), @p42='?' (Size = 50), @p43='?' (DbType = Int32), @p44='?' (Size = 255), @p45='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p46='?' (Size = 1) (DbType = Byte), @p47='?' (Precision = 10) (Scale = 4) (DbType = Decimal), @p48='?' (Size = 100), @p49='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p50='?' (Precision = 18) (Scale = 4) (DbType = Decimal), @p51='?' (DbType = Int16)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      MERGE [dbo].[OverallKpiResult] USING (
      VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, 0),
      (@p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22, @p23, @p24, @p25, 1),
      (@p26, @p27, @p28, @p29, @p30, @p31, @p32, @p33, @p34, @p35, @p36, @p37, @p38, 2),
      (@p39, @p40, @p41, @p42, @p43, @p44, @p45, @p46, @p47, @p48, @p49, @p50, @p51, 3)) AS i ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year], _Position) ON 1=0
      WHEN NOT MATCHED THEN
      INSERT ([AchievedValue], [AreaCode], [CalculatedAt], [KpiCode], [KpiDefinitionId], [KpiName], [PointsApplicable], [Month], [OverallKpiValuePercent], [Platform], [PointsAchieved], [TargetValue], [Year])
      VALUES (i.[AchievedValue], i.[AreaCode], i.[CalculatedAt], i.[KpiCode], i.[KpiDefinitionId], i.[KpiName], i.[PointsApplicable], i.[Month], i.[OverallKpiValuePercent], i.[Platform], i.[PointsAchieved], i.[TargetValue], i.[Year])
      OUTPUT INSERTED.[Id], i._Position;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@__serviceId_0='?' (Size = 20)], CommandType='Text', CommandTimeout='30']
      SELECT TOP(1) [u].[UserId], [u].[CreatedAt], [u].[Email], [u].[IsActive], [u].[LastLogin], [u].[Name], [u].[RoleId], [u].[ServiceId], [u].[UpdatedAt], [r].[RoleId], [r].[CreatedAt], [r].[RoleName]
      FROM [dbo].[Users] AS [u]
      INNER JOIN [dbo].[Roles] AS [r] ON [u].[RoleId] = [r].[RoleId]
      WHERE [u].[ServiceId] = @__serviceId_0
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (1ms) [Parameters=[@p1='?' (DbType = Int32), @p0='?' (DbType = DateTime2)], CommandType='Text', CommandTimeout='30']
      SET IMPLICIT_TRANSACTIONS OFF;
      SET NOCOUNT ON;
      UPDATE [dbo].[Users] SET [LastLogin] = @p0
      OUTPUT 1
      WHERE [UserId] = @p1;
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@__user_UserId_0='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [u].[PageId]
      FROM [dbo].[UserPageAccess] AS [u]
      WHERE [u].[UserId] = @__user_UserId_0 AND [u].[PageId] IN (CAST(1 AS tinyint), CAST(2 AS tinyint), CAST(3 AS tinyint), CAST(4 AS tinyint), CAST(6 AS tinyint), CAST(7 AS tinyint), CAST(8 AS tinyint), CAST(9 AS tinyint), CAST(10 AS tinyint))
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (0ms) [Parameters=[@__user_UserId_0='?' (DbType = Int32)], CommandType='Text', CommandTimeout='30']
      SELECT [p].[PageId]
      FROM [dbo].[PlatformKpiAssignment] AS [p]
      WHERE [p].[UserId] = @__user_UserId_0 AND [p].[PageId] IN (CAST(1 AS tinyint), CAST(2 AS tinyint), CAST(3 AS tinyint), CAST(4 AS tinyint), CAST(6 AS tinyint), CAST(7 AS tinyint), CAST(8 AS tinyint), CAST(9 AS tinyint), CAST(10 AS tinyint))
info: Microsoft.EntityFrameworkCore.Database.Command[20101]
      Executed DbCommand (10ms) [Parameters=[@__year_0='?' (DbType = Int16), @__startMonth_1='?' (Size = 1) (DbType = Byte), @__endMonth_2='?' (Size = 1) (DbType = Byte)], CommandType='Text', CommandTimeout='30']
      SELECT [o].[Id], [o].[AchievedValue], [o].[AreaCode], [o].[CalculatedAt], [o].[KpiCode], [o].[KpiDefinitionId], [o].[KpiName], [o].[PointsApplicable], [o].[Month], [o].[OverallKpiValuePercent], [o].[Platform], [o].[PointsAchieved], [o].[TargetValue], [o].[Year]
      FROM [dbo].[OverallKpiResult] AS [o]
      WHERE [o].[Year] = @__year_0 AND [o].[Month] >= @__startMonth_1 AND [o].[Month] <= @__endMonth_2
