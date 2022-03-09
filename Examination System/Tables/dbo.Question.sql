CREATE TABLE [dbo].[Question]
(
[Q_Id] [int] NOT NULL,
[Q_type] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Q_desc] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Crs_Id] [int] NULL,
[Modal_Answer] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [PK__Question__F4FC370EFC63885D] PRIMARY KEY CLUSTERED ([Q_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [Q_CrsFK] FOREIGN KEY ([Crs_Id]) REFERENCES [dbo].[Course] ([Crs_Id])
GO
