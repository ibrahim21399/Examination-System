CREATE TABLE [dbo].[Exam_Q]
(
[Exam_Id] [int] NOT NULL,
[Q_Id] [int] NOT NULL,
[Q_Number] [int] NULL,
[Checked_Ans] [varchar] (1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exam_Q] ADD CONSTRAINT [PK_Exam_Q] PRIMARY KEY CLUSTERED ([Exam_Id], [Q_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exam_Q] ADD CONSTRAINT [Exam_Exam_QFK] FOREIGN KEY ([Exam_Id]) REFERENCES [dbo].[Exam] ([Exam_Id])
GO
ALTER TABLE [dbo].[Exam_Q] ADD CONSTRAINT [Q_Exam_QFK] FOREIGN KEY ([Q_Id]) REFERENCES [dbo].[Question] ([Q_Id])
GO
