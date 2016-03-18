CREATE TABLE [dbo].[PublisherEmails] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [PublisherId] INT           NOT NULL,
    [Description] NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_PublisherEmails] PRIMARY KEY CLUSTERED ([Id] ASC)
);

