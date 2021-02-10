IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210209155554_create database')
BEGIN
    CREATE TABLE [Products] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(120) NOT NULL,
        [Description] nvarchar(300) NULL,
        [Quantity] int NOT NULL,
        [PurchasePrice] float NOT NULL,
        [SalePrice] float NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210209155554_create database')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210209155554_create database', N'5.0.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210209163332_carga datos')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name', N'PurchasePrice', N'Quantity', N'SalePrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    EXEC(N'INSERT INTO [Products] ([Id], [Description], [Name], [PurchasePrice], [Quantity], [SalePrice])
    VALUES (1, N''Apple MacBook Pro is a macOS laptop with a 13.30-inch display that has a resolution of 2560x1600 pixels'', N''MacBook'', 2000.0E0, 10, 2300.0E0),
    (2, N''Active noise cancellation for immersive sound. Transparency mode for hearing and connecting with the world around you'', N''Apple - AirPods Pro - White'', 150.0E0, 10, 190.0E0),
    (3, N''Bring a theater experience to your home with this Sony BRAVIA 77-inch OLED 4K HDR TV.'', N''Smart Android TV Sony - 77 TV Class A9G OLED 4K UHD '', 3500.0E0, 10, 3900.0E0),
    (4, N''The iPhone 12 features a 6.1-inch (15.3-cm) display with Super Retina XDR OLED technology at a resolution of 2532×1170 pixels and a pixel density of about 460 ppi'', N''iPhone 12'', 900.0E0, 10, 1200.0E0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Description', N'Name', N'PurchasePrice', N'Quantity', N'SalePrice') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210209163332_carga datos')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210209163332_carga datos', N'5.0.2');
END;
GO

COMMIT;
GO

