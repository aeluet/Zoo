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

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240414070922_InicioBBDD'
)
BEGIN
    CREATE TABLE [Lekuak] (
        [ID] int NOT NULL IDENTITY,
        [Izena] nvarchar(max) NOT NULL,
        [Deskribapena] nvarchar(max) NULL,
        CONSTRAINT [PK_Lekuak] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240414070922_InicioBBDD'
)
BEGIN
    CREATE TABLE [Arrazak] (
        [ID] int NOT NULL IDENTITY,
        [Izena] nvarchar(max) NOT NULL,
        [Deskribapena] nvarchar(max) NULL,
        [ID_lekua] int NULL,
        [ImageUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_Arrazak] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Arrazak_Lekuak_ID_lekua] FOREIGN KEY ([ID_lekua]) REFERENCES [Lekuak] ([ID])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240414070922_InicioBBDD'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'Izena') AND [object_id] = OBJECT_ID(N'[Lekuak]'))
        SET IDENTITY_INSERT [Lekuak] ON;
    EXEC(N'INSERT INTO [Lekuak] ([ID], [Deskribapena], [Izena])
    VALUES (1, N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.'', N''Interior1''),
    (2, N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.'', N''Interior2''),
    (3, N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.'', N''Sabana''),
    (4, N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.'', N''Lago''),
    (5, N''Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.'', N''Bosque'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'Izena') AND [object_id] = OBJECT_ID(N'[Lekuak]'))
        SET IDENTITY_INSERT [Lekuak] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240414070922_InicioBBDD'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'ID_lekua', N'ImageUrl', N'Izena') AND [object_id] = OBJECT_ID(N'[Arrazak]'))
        SET IDENTITY_INSERT [Arrazak] ON;
    EXEC(N'INSERT INTO [Arrazak] ([ID], [Deskribapena], [ID_lekua], [ImageUrl], [Izena])
    VALUES (1, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 1, N'''', N''Tigre''),
    (2, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 2, N'''', N''Leon''),
    (3, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 3, N'''', N''Pato''),
    (4, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 4, N'''', N''Panda''),
    (5, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 5, N'''', N''Conejo''),
    (6, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 2, N'''', N''Delfin'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'ID_lekua', N'ImageUrl', N'Izena') AND [object_id] = OBJECT_ID(N'[Arrazak]'))
        SET IDENTITY_INSERT [Arrazak] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240414070922_InicioBBDD'
)
BEGIN
    CREATE INDEX [IX_Arrazak_ID_lekua] ON [Arrazak] ([ID_lekua]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240414070922_InicioBBDD'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240414070922_InicioBBDD', N'9.0.0-preview.1.24081.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [Discriminator] nvarchar(13) NOT NULL,
        [Izena] nvarchar(max) NULL,
        [Abizena] nvarchar(max) NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240415074705_AddUsersTables'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240415074705_AddUsersTables', N'9.0.0-preview.1.24081.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUserTokens]') AND [c].[name] = N'Name');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUserTokens] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [AspNetUserTokens] ALTER COLUMN [Name] nvarchar(450) NOT NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUserTokens]') AND [c].[name] = N'LoginProvider');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUserTokens] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [AspNetUserTokens] ALTER COLUMN [LoginProvider] nvarchar(450) NOT NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUserLogins]') AND [c].[name] = N'ProviderKey');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUserLogins] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [AspNetUserLogins] ALTER COLUMN [ProviderKey] nvarchar(450) NOT NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUserLogins]') AND [c].[name] = N'LoginProvider');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUserLogins] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [AspNetUserLogins] ALTER COLUMN [LoginProvider] nvarchar(450) NOT NULL;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    CREATE TABLE [Animalia] (
        [ID] int NOT NULL IDENTITY,
        [Izena] nvarchar(max) NOT NULL,
        [Sarrera_data] date NOT NULL,
        [urte_betetzea] date NOT NULL,
        [ID_arraza] int NULL,
        [ImageUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_Animalia] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animalia]'))
        SET IDENTITY_INSERT [Animalia] ON;
    EXEC(N'INSERT INTO [Animalia] ([ID], [ID_arraza], [ImageUrl], [Izena], [Sarrera_data], [urte_betetzea])
    VALUES (1, 1, N'''', N''Tony the Terrific Tige'', ''2024-04-01'', ''2021-10-05''),
    (2, 7, N'''', N''Eric the Enthusiastic Elephant'', ''0202-11-30'', ''2019-04-20''),
    (3, 1, N'''', N''Tara the Tremendous Tiger'', ''2021-04-05'', ''2021-10-10'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animalia]'))
        SET IDENTITY_INSERT [Animalia] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'ID_lekua', N'ImageUrl', N'Izena') AND [object_id] = OBJECT_ID(N'[Arrazak]'))
        SET IDENTITY_INSERT [Arrazak] ON;
    EXEC(N'INSERT INTO [Arrazak] ([ID], [Deskribapena], [ID_lekua], [ImageUrl], [Izena])
    VALUES (7, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 3, N'''', N''Elephant'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'ID_lekua', N'ImageUrl', N'Izena') AND [object_id] = OBJECT_ID(N'[Arrazak]'))
        SET IDENTITY_INSERT [Arrazak] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416070437_addAnimaliakToDb'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240416070437_addAnimaliakToDb', N'9.0.0-preview.1.24081.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416085407_PorSiAcaso'
)
BEGIN
    DROP TABLE [Animalia];
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416085407_PorSiAcaso'
)
BEGIN
    CREATE TABLE [Animaliak] (
        [ID] int NOT NULL IDENTITY,
        [Izena] nvarchar(max) NOT NULL,
        [Sarrera_data] date NOT NULL,
        [urte_betetzea] date NOT NULL,
        [ID_arraza] int NULL,
        [ImageUrl] nvarchar(max) NULL,
        CONSTRAINT [PK_Animaliak] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_Animaliak_Arrazak_ID_arraza] FOREIGN KEY ([ID_arraza]) REFERENCES [Arrazak] ([ID])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416085407_PorSiAcaso'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animaliak]'))
        SET IDENTITY_INSERT [Animaliak] ON;
    EXEC(N'INSERT INTO [Animaliak] ([ID], [ID_arraza], [ImageUrl], [Izena], [Sarrera_data], [urte_betetzea])
    VALUES (1, 1, N'''', N''Tony the Terrific Tige'', ''2024-04-01'', ''2021-10-05''),
    (2, 7, N'''', N''Eric the Enthusiastic Elephant'', ''0202-11-30'', ''2019-04-20''),
    (3, 1, N'''', N''Tara the Tremendous Tiger'', ''2021-04-05'', ''2021-10-10'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animaliak]'))
        SET IDENTITY_INSERT [Animaliak] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416085407_PorSiAcaso'
)
BEGIN
    CREATE INDEX [IX_Animaliak_ID_arraza] ON [Animaliak] ([ID_arraza]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240416085407_PorSiAcaso'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240416085407_PorSiAcaso', N'9.0.0-preview.1.24081.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Izena] = N''Charlie the Charming Chimpanzee''
    WHERE [ID] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [ID_arraza] = 2, [Izena] = N''Goliath the Gentle Giant Gorilla'', [Sarrera_data] = ''2024-04-01'', [urte_betetzea] = ''2021-10-05''
    WHERE [ID] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [ID_arraza] = 3, [Izena] = N''Ruby the Radiant Red Panda'', [Sarrera_data] = ''2024-04-01'', [urte_betetzea] = ''2021-10-05''
    WHERE [ID] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animaliak]'))
        SET IDENTITY_INSERT [Animaliak] ON;
    EXEC(N'INSERT INTO [Animaliak] ([ID], [ID_arraza], [ImageUrl], [Izena], [Sarrera_data], [urte_betetzea])
    VALUES (4, 4, N'''', N''Kenny the Kicking Kangaroo'', ''2024-04-01'', ''2021-10-05''),
    (5, 5, N'''', N''Sammy the Sleepy Sloth'', ''2024-04-01'', ''2021-10-05''),
    (6, 6, N'''', N''Aurora the Agile Arctic Fox'', ''2024-04-01'', ''2021-10-05''),
    (7, 7, N'''', N''Eleanor the Elegant Elephant'', ''2024-04-01'', ''2021-10-05''),
    (13, 7, N'''', N''Eric the Enthusiastic Elephant'', ''2024-04-01'', ''2021-10-05''),
    (24, 1, N'''', N''Charlie the Cheerful Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (25, 1, N'''', N''Chloe the Charming Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (26, 1, N'''', N''Chip the Clever Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (27, 1, N'''', N''Charlotte the Curious Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (28, 1, N'''', N''Cooper the Confident Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (29, 1, N'''', N''Cindy the Cute Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (30, 1, N'''', N''Connor the Cuddly Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (31, 1, N'''', N''Cleo the Creative Chimpanzee'', ''2024-04-01'', ''2021-10-05''),
    (44, 2, N'''', N''Gus the Gentle Giant Gorilla'', ''2024-04-01'', ''2021-10-05''),
    (45, 2, N'''', N''Greta the Gracious Gorilla'', ''2024-04-01'', ''2021-10-05''),
    (46, 2, N'''', N''Greg the Gentle Gorilla'', ''2024-04-01'', ''2021-10-05''),
    (47, 2, N'''', N''Gigi the Gorgeous Gorilla'', ''2024-04-01'', ''2021-10-05''),
    (48, 3, N'''', N''Rusty the Radiant Red Panda'', ''2024-04-01'', ''2021-10-05'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animaliak]'))
        SET IDENTITY_INSERT [Animaliak] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Arrazak] SET [Izena] = N''Chimpanze''
    WHERE [ID] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Arrazak] SET [Izena] = N''Gorila''
    WHERE [ID] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Arrazak] SET [Izena] = N''Panda Rojo''
    WHERE [ID] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Arrazak] SET [Izena] = N''Canguro''
    WHERE [ID] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Arrazak] SET [Izena] = N''Perezoso''
    WHERE [ID] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Arrazak] SET [Izena] = N''Zorro artico''
    WHERE [ID] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    EXEC(N'UPDATE [Arrazak] SET [Izena] = N''Elefante''
    WHERE [ID] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'ID_lekua', N'ImageUrl', N'Izena') AND [object_id] = OBJECT_ID(N'[Arrazak]'))
        SET IDENTITY_INSERT [Arrazak] ON;
    EXEC(N'INSERT INTO [Arrazak] ([ID], [Deskribapena], [ID_lekua], [ImageUrl], [Izena])
    VALUES (8, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 2, N'''', N''Flamenco''),
    (9, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 4, N'''', N''Oso polar''),
    (10, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 4, N'''', N''Pinguino''),
    (11, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 2, N'''', N''Surikata''),
    (12, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 2, N'''', N''Giboi''),
    (13, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 1, N'''', N''Girafa''),
    (14, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 1, N'''', N''Koala''),
    (15, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 3, N'''', N''Mono''),
    (16, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 3, N'''', N''Zebra''),
    (17, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 5, N'''', N''Leon''),
    (18, N''Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.'', 5, N'''', N''Tigre'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'Deskribapena', N'ID_lekua', N'ImageUrl', N'Izena') AND [object_id] = OBJECT_ID(N'[Arrazak]'))
        SET IDENTITY_INSERT [Arrazak] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animaliak]'))
        SET IDENTITY_INSERT [Animaliak] ON;
    EXEC(N'INSERT INTO [Animaliak] ([ID], [ID_arraza], [ImageUrl], [Izena], [Sarrera_data], [urte_betetzea])
    VALUES (8, 8, N'''', N''Felicia the Flamboyant Flamingo'', ''2024-04-01'', ''2021-10-05''),
    (9, 9, N'''', N''Percy the Playful Polar Bear'', ''2024-04-01'', ''2021-10-05''),
    (10, 10, N'''', N''Penny the Perky Penguin'', ''2024-04-01'', ''2021-10-05''),
    (11, 11, N'''', N''Milo the Mischievous Meerkat'', ''2024-04-01'', ''2021-10-05''),
    (12, 12, N'''', N''Gracie the Graceful Gibbon'', ''2024-04-01'', ''2021-10-05''),
    (14, 8, N'''', N''Fiona the Fancy Flamingo'', ''2024-04-01'', ''2021-10-05''),
    (15, 13, N'''', N''Gerald the Gentle Giraffe'', ''2024-04-01'', ''2021-10-05''),
    (16, 14, N'''', N''Katie the Cuddly Koala'', ''2024-04-01'', ''2021-10-05''),
    (17, 15, N'''', N''Manny the Merry Monkey'', ''2024-04-01'', ''2021-10-05''),
    (18, 16, N'''', N''Zara the Zesty Zebra'', ''2024-04-01'', ''2021-10-05''),
    (19, 17, N'''', N''Leo the Majestic Lion'', ''2024-04-01'', ''2021-10-05''),
    (20, 17, N'''', N''Luna the Fierce Lioness'', ''2024-04-01'', ''2021-10-05''),
    (21, 17, N'''', N''Max the Mighty Lion'', ''2024-04-01'', ''2021-10-05''),
    (22, 17, N'''', N''Lola the Lovely Lioness'', ''2024-04-01'', ''2021-10-05''),
    (23, 17, N'''', N''Simba the Courageous Lion'', ''2024-04-01'', ''2021-10-05''),
    (32, 10, N'''', N''Paul the Playful Penguin'', ''2024-04-01'', ''2021-10-05''),
    (33, 10, N'''', N''Poppy the Perky Penguin'', ''2024-04-01'', ''2021-10-05''),
    (34, 10, N'''', N''Percy the Pensive Penguin'', ''2024-04-01'', ''2021-10-05''),
    (35, 10, N'''', N''Penny the Polite Penguin'', ''2024-04-01'', ''2021-10-05''),
    (36, 10, N'''', N''Pablo the Playful Penguin'', ''2024-04-01'', ''2021-10-05''),
    (37, 10, N'''', N''Polly the Prancing Penguin'', ''2024-04-01'', ''2021-10-05''),
    (38, 10, N'''', N''Peter the Peaceful Penguin'', ''2024-04-01'', ''2021-10-05''),
    (39, 10, N'''', N''Penelope the Patient Penguin'', ''2024-04-01'', ''2021-10-05''),
    (40, 10, N'''', N''Patrick the Playful Penguin'', ''2024-04-01'', ''2021-10-05''),
    (41, 10, N'''', N''Pippa the Prankster Penguin'', ''2024-04-01'', ''2021-10-05''),
    (42, 16, N'''', N''Zara the Zany Zebra'', ''2024-04-01'', ''2021-10-05''),
    (43, 16, N'''', N''Ziggy the Zippy Zebra'', ''2024-04-01'', ''2021-10-05''),
    (49, 18, N'''', N''Tony the Terrific Tiger'', ''2024-04-01'', ''2021-10-05''),
    (50, 18, N'''', N''Tara the Tremendous Tiger'', ''2024-04-01'', ''2021-10-05''),
    (51, 18, N'''', N''Tim the Tenacious Tiger'', ''2024-04-01'', ''2021-10-05''),
    (52, 18, N'''', N''Tess the Fearless Tiger'', ''2024-04-01'', ''2021-10-05''),
    (53, 18, N'''', N''Tyler the Triumphant Tiger'', ''2024-04-01'', ''2021-10-05''),
    (54, 18, N'''', N''Tina the Tenacious Tiger'', ''2024-04-01'', ''2021-10-05'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ID', N'ID_arraza', N'ImageUrl', N'Izena', N'Sarrera_data', N'urte_betetzea') AND [object_id] = OBJECT_ID(N'[Animaliak]'))
        SET IDENTITY_INSERT [Animaliak] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240424111114_NewAnimaliakEtaArrazak'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240424111114_NewAnimaliakEtaArrazak', N'9.0.0-preview.1.24081.2');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2022-05-15'', [urte_betetzea] = ''2019-03-10''
    WHERE [ID] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2021-10-20'', [urte_betetzea] = ''2018-07-05''
    WHERE [ID] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2023-01-08'', [urte_betetzea] = ''2020-02-15''
    WHERE [ID] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2020-12-03'', [urte_betetzea] = ''2017-09-22''
    WHERE [ID] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2023-04-25'', [urte_betetzea] = ''2020-10-30''
    WHERE [ID] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2022-08-12'', [urte_betetzea] = ''2019-06-18''
    WHERE [ID] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2021-11-30'', [urte_betetzea] = ''2019-04-20''
    WHERE [ID] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2022-09-15'', [urte_betetzea] = ''2020-01-05''
    WHERE [ID] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2020-07-22'', [urte_betetzea] = ''2018-10-12''
    WHERE [ID] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2023-02-28'', [urte_betetzea] = ''2020-08-20''
    WHERE [ID] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2021-12-10'', [urte_betetzea] = ''2019-05-03''
    WHERE [ID] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2022-06-05'', [urte_betetzea] = ''2019-01-18''
    WHERE [ID] = 12;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2023-04-12'', [urte_betetzea] = ''2020-01-30''
    WHERE [ID] = 13;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2023-07-19'', [urte_betetzea] = ''2021-02-10''
    WHERE [ID] = 14;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2023-08-20'', [urte_betetzea] = ''2020-12-05''
    WHERE [ID] = 15;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-01-15'', [urte_betetzea] = ''2021-05-25''
    WHERE [ID] = 16;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-03-01'', [urte_betetzea] = ''2021-09-12''
    WHERE [ID] = 17;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-02-10'', [urte_betetzea] = ''2021-06-25''
    WHERE [ID] = 18;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-03-10'', [urte_betetzea] = ''2021-08-25''
    WHERE [ID] = 19;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-03-15'', [urte_betetzea] = ''2021-09-02''
    WHERE [ID] = 20;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-03-20'', [urte_betetzea] = ''2021-09-10''
    WHERE [ID] = 21;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-03-25'', [urte_betetzea] = ''2021-09-18''
    WHERE [ID] = 22;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-03-28'', [urte_betetzea] = ''2021-09-22''
    WHERE [ID] = 23;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-05'', [urte_betetzea] = ''2021-10-10''
    WHERE [ID] = 25;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-10'', [urte_betetzea] = ''2021-10-15''
    WHERE [ID] = 26;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-15'', [urte_betetzea] = ''2021-10-20''
    WHERE [ID] = 27;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-20'', [urte_betetzea] = ''2021-10-25''
    WHERE [ID] = 28;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-25'', [urte_betetzea] = ''2021-10-30''
    WHERE [ID] = 29;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-30'', [urte_betetzea] = ''2021-11-05''
    WHERE [ID] = 30;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-05-05'', [urte_betetzea] = ''2021-11-10''
    WHERE [ID] = 31;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-05'', [urte_betetzea] = ''2021-10-10''
    WHERE [ID] = 33;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-10'', [urte_betetzea] = ''2021-10-15''
    WHERE [ID] = 34;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-15'', [urte_betetzea] = ''2021-10-20''
    WHERE [ID] = 35;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-20'', [urte_betetzea] = ''2021-10-25''
    WHERE [ID] = 36;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-25'', [urte_betetzea] = ''2021-10-30''
    WHERE [ID] = 37;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-30'', [urte_betetzea] = ''2021-11-05''
    WHERE [ID] = 38;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-05-05'', [urte_betetzea] = ''2021-11-10''
    WHERE [ID] = 39;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-05-10'', [urte_betetzea] = ''2021-11-15''
    WHERE [ID] = 40;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-05-15'', [urte_betetzea] = ''2021-11-20''
    WHERE [ID] = 41;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-05'', [urte_betetzea] = ''2021-10-10''
    WHERE [ID] = 42;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-10'', [urte_betetzea] = ''2021-10-15''
    WHERE [ID] = 43;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-05'', [urte_betetzea] = ''2021-10-10''
    WHERE [ID] = 45;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-10'', [urte_betetzea] = ''2021-10-15''
    WHERE [ID] = 46;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-15'', [urte_betetzea] = ''2021-10-20''
    WHERE [ID] = 47;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-05'', [urte_betetzea] = ''2021-10-10''
    WHERE [ID] = 50;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-10'', [urte_betetzea] = ''2021-10-15''
    WHERE [ID] = 51;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-15'', [urte_betetzea] = ''2021-10-20''
    WHERE [ID] = 52;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-20'', [urte_betetzea] = ''2021-10-25''
    WHERE [ID] = 53;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    EXEC(N'UPDATE [Animaliak] SET [Sarrera_data] = ''2024-04-25'', [urte_betetzea] = ''2021-10-30''
    WHERE [ID] = 54;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20240425063552_AddFechas'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20240425063552_AddFechas', N'9.0.0-preview.1.24081.2');
END;
GO

COMMIT;
GO

