USE [C:\USERS\MARTA.GALLEGO\SOURCE\REPOS\WINDOWSFORMSAPP1\WINDOWSFORMSAPP1\BIN\DEBUG\DATABASE.MDF]
GO

/****** Objeto: Table [dbo].[users] Fecha del script: 09/01/2023 14:08:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users] (
    [Id]       INT          NOT  NULL,
    [nombre]   NCHAR (40)     NULL,
    [email]    NCHAR (255)    NULL,
    [password] VARBINARY (50) NULL,
    [Rol]      NCHAR (100)    NULL
);
GO

