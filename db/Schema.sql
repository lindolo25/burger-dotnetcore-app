CREATE DATABASE [burgers_db];

USE [burgers_db]
GO

CREATE TABLE [dbo].[burgers](
	[burger_id] [int] IDENTITY(1,1) NOT NULL,
	[burger_name] [varchar](255) NOT NULL,
	[is_devoured] [bit] NOT NULL,
	CONSTRAINT [PK_burgers] PRIMARY KEY CLUSTERED 
	(
		[burger_id] ASC
	)WITH 
	(
		PAD_INDEX = OFF,
		STATISTICS_NORECOMPUTE = OFF,
		IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON
	) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[burgers] ADD  CONSTRAINT [DF_burgers_is_devoured]  DEFAULT ((0)) FOR [is_devoured]
GO

