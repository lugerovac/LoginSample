CREATE TABLE [dbo].[Publisher] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (100) NOT NULL,
    [Address] NVARCHAR (150) NULL,
    [WebPage] NVARCHAR (250) NULL,
    [LogoId]  INT            NULL,
    CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED ([Id] ASC)
);

