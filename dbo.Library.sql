CREATE TABLE [dbo].[Library] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Journal]      NVARCHAR (50) NULL,
    [Article]      NVARCHAR (50) NULL,
    [Authors]      NVARCHAR (50) NULL,
    [Year]         INT           NULL,
    [Volume]       INT           NULL,
    [Number]       INT           NULL,
    [FirstPage] INT           NULL,
    [EndPage]      INT         NULL,
    [Picture] IMAGE NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

