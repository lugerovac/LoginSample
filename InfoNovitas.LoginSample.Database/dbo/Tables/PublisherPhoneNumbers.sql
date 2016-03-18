CREATE TABLE [dbo].[PublisherPhoneNumbers] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [PublisherId] INT           NOT NULL,
    [Description] NVARCHAR (50) NOT NULL,
    [PhoneNumber] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_PublisherPhoneNumbers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

