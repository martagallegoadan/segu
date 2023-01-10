CREATE TABLE [dbo].[users] (
    [Id]       INT         NOT NULL,
    [nombre]   NCHAR (40)  NULL,
    [email]    NCHAR (255) NULL,
    [password] VARBINARY(50)  NULL,
    [Rol]      NCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
