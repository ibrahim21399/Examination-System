CREATE TABLE [dbo].[Choice]
(
[Choice_Id] [int] NOT NULL,
[Choice_Letter] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Choice_Desc] [varchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Q_Id] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Choice] ADD CONSTRAINT [PK__Choice__D6C8DAFA9E075CA3] PRIMARY KEY CLUSTERED ([Choice_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Choice] ADD CONSTRAINT [Choice_QFK] FOREIGN KEY ([Q_Id]) REFERENCES [dbo].[Question] ([Q_Id]) ON DELETE SET NULL ON UPDATE CASCADE
GO
