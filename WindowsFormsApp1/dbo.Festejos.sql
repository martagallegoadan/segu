CREATE TABLE [dbo].[Festejos] (
    [Id]           INT         NULL,
    [festejo]      NCHAR (255) NOT NULL,
    [tipo_festejo] NCHAR (255) NULL,
    [localidad]    NCHAR (255) NULL,
    [provincia]    NCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([festejo] ASC)
);

