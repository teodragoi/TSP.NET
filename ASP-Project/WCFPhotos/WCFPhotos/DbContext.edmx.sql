
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/27/2020 21:16:46
-- Generated from EDMX file: D:\Anul III\Sem II\TSP.NET\WCF-Project\WCFPhotos\WCFPhotos\DbContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WCF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Event] nvarchar(max)  NOT NULL,
    [PhotoUrl] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonPhoto'
CREATE TABLE [dbo].[PersonPhoto] (
    [PersonPhoto_Photo_Id] int  NOT NULL,
    [PersonPhoto_Person_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [PersonPhoto_Photo_Id], [PersonPhoto_Person_Id] in table 'PersonPhoto'
ALTER TABLE [dbo].[PersonPhoto]
ADD CONSTRAINT [PK_PersonPhoto]
    PRIMARY KEY CLUSTERED ([PersonPhoto_Photo_Id], [PersonPhoto_Person_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonPhoto_Photo_Id] in table 'PersonPhoto'
ALTER TABLE [dbo].[PersonPhoto]
ADD CONSTRAINT [FK_PersonPhoto_Person]
    FOREIGN KEY ([PersonPhoto_Photo_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PersonPhoto_Person_Id] in table 'PersonPhoto'
ALTER TABLE [dbo].[PersonPhoto]
ADD CONSTRAINT [FK_PersonPhoto_Photo]
    FOREIGN KEY ([PersonPhoto_Person_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPhoto_Photo'
CREATE INDEX [IX_FK_PersonPhoto_Photo]
ON [dbo].[PersonPhoto]
    ([PersonPhoto_Person_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------