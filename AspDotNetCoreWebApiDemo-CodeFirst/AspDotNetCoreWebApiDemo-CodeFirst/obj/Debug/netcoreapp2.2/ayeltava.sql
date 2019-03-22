IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Employees] (
    [EmployeeId] bigint NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190321092745_AspDotNetCoreWebApiDemo_CodeFirst.Model.TestDbContext', N'2.2.3-servicing-35854');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] ON;
INSERT INTO [Employees] ([EmployeeId], [DateOfBirth], [Email], [FirstName], [LastName], [PhoneNumber])
VALUES (CAST(1 AS bigint), '1979-04-25T00:00:00.0000000', N'uncle.bob@gmail.com', N'Uncle', N'Bob', N'999-888-7777');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] ON;
INSERT INTO [Employees] ([EmployeeId], [DateOfBirth], [Email], [FirstName], [LastName], [PhoneNumber])
VALUES (CAST(2 AS bigint), '1981-07-13T00:00:00.0000000', N'jan.kirsten@gmail.com', N'Jan', N'Kirsten', N'111-222-3333');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190321093248_EFCoreCodeFirstSample.Models.EmployeeContextSeed', N'2.2.3-servicing-35854');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] ON;
INSERT INTO [Employees] ([EmployeeId], [DateOfBirth], [Email], [FirstName], [LastName], [PhoneNumber])
VALUES (CAST(3 AS bigint), '1981-07-13T00:00:00.0000000', N'mary.kirsten@gmail.com', N'mary', N'Kirsten', N'333-222-3333');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190322054116_AspDotNetCoreWebApiDemo_CodeFirst.Model.AddEmployeeGender', N'2.2.3-servicing-35854');

GO

ALTER TABLE [Employees] ADD [Gender] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190322054711_AspDotNetCoreWebApiDemo_CodeFirst.Model.AddEmployeeGenderAgain', N'2.2.3-servicing-35854');

GO

