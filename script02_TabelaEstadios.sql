BEGIN TRANSACTION;
CREATE TABLE [TB_ESTADIOS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Cidade] nvarchar(max) NOT NULL,
    [Capacidade] int NOT NULL,
    CONSTRAINT [PK_TB_ESTADIOS] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIOS]'))
    SET IDENTITY_INSERT [TB_ESTADIOS] ON;
INSERT INTO [TB_ESTADIOS] ([Id], [Capacidade], [Cidade], [Nome])
VALUES (1, 50000, N'Sao Paulo', N'Neo Quimica Arena'),
(2, 80000, N'Sao Paulo', N'Morumbis'),
(3, 40000, N'Sao Paulo', N'Chiqueiro'),
(4, 67676, N'Sao Paulo', N'Siri boy Arena'),
(5, 80000, N'Paris', N'Parque dos principes'),
(6, 40000, N'Salvador', N'Fonte Nova'),
(7, 77777, N'Sao Paulo', N'Aura Stadium');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Capacidade', N'Cidade', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ESTADIOS]'))
    SET IDENTITY_INSERT [TB_ESTADIOS] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260406111425_MigracaoEstadios', N'10.0.5');

COMMIT;
GO

