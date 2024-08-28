USE [Company]
GO

/****** Object: Table [dbo].[Employee] Script Date: 20-08-2024 14:21:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Employee];


GO
CREATE TABLE [dbo].[Employee] (
    [Id]           INT     identity(1,1 )     NOT NULL,
    [DepartmentId] INT           NULL,
    [Name]         VARCHAR (100) NULL,
    [Designation]  VARCHAR (25)  NULL,
	constraint pk_employee primary key(id)
);


