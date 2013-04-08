-- SQL Manager 2008 for SQL Server 3.0.0.1
-- ---------------------------------------
-- Host      : win8pc
-- Database  : WebNote
-- Version   : Microsoft SQL Server  10.50.2500.0


CREATE DATABASE [WebNote]
COLLATE Cyrillic_General_CI_AS
GO

USE [WebNote]
GO


--
-- Definition for table Categories : 
--

CREATE TABLE [dbo].[Categories] (
  [FID] int IDENTITY(1, 1) NOT NULL,
  [FNAME] nvarchar(40) COLLATE Cyrillic_General_CI_AS NULL,
  CONSTRAINT [Categories_pk] PRIMARY KEY CLUSTERED ([FID])
)
ON [PRIMARY]
GO

--
-- Definition for table Notes : 
--

CREATE TABLE [dbo].[Notes] (
  [FID] int IDENTITY(1, 1) NOT NULL,
  [FCATEGORY_ID] int NOT NULL,
  [FTITLE] nvarchar(50) COLLATE Cyrillic_General_CI_AS NULL,
  [FCONTENT] nvarchar(max) COLLATE Cyrillic_General_CI_AS NULL,
  [FTIMESTAMP] bigint NULL,
  CONSTRAINT [Notes_pk] PRIMARY KEY CLUSTERED ([FID]),
  CONSTRAINT [Notes_fk] FOREIGN KEY ([FCATEGORY_ID]) 
  REFERENCES [dbo].[Categories] ([FID]) 
  ON UPDATE NO ACTION
  ON DELETE NO ACTION
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[Notes]
NOCHECK CONSTRAINT [Notes_fk]
GO

--
-- Data for table dbo.Categories  (LIMIT 0,500)
--

SET IDENTITY_INSERT [dbo].[Categories] ON
GO

INSERT INTO [dbo].[Categories] ([FID], [FNAME])
VALUES 
  (1, N'Category 1')
GO

INSERT INTO [dbo].[Categories] ([FID], [FNAME])
VALUES 
  (2, N'Category 2')
GO

INSERT INTO [dbo].[Categories] ([FID], [FNAME])
VALUES 
  (3, N'Category 3')
GO

SET IDENTITY_INSERT [dbo].[Categories] OFF
GO

--
-- Data for table dbo.Notes  (LIMIT 0,500)
--

SET IDENTITY_INSERT [dbo].[Notes] ON
GO

INSERT INTO [dbo].[Notes] ([FID], [FCATEGORY_ID], [FTITLE], [FCONTENT], [FTIMESTAMP])
VALUES 
  (10, 1, N'Note Title 1', N'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.', 1365377331000)
GO

INSERT INTO [dbo].[Notes] ([FID], [FCATEGORY_ID], [FTITLE], [FCONTENT], [FTIMESTAMP])
VALUES 
  (11, 2, N'Note Title Nr. 2', N'Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.', 1365375094000)
GO

INSERT INTO [dbo].[Notes] ([FID], [FCATEGORY_ID], [FTITLE], [FCONTENT], [FTIMESTAMP])
VALUES 
  (12, 3, N'Note Title Third', N'Some Content.', 1365377568000)
GO

SET IDENTITY_INSERT [dbo].[Notes] OFF
GO

