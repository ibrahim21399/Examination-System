CREATE TABLE [dbo].[Exam]
(
[Exam_Id] [int] NOT NULL,
[Exam_Date] [date] NULL,
[Std_Id] [int] NULL,
[Crs_Id] [int] NULL,
[Grade] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exam] ADD CONSTRAINT [PK__Exam__C782CA59E98580F5] PRIMARY KEY CLUSTERED ([Exam_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exam] ADD CONSTRAINT [Exam_CrsFK] FOREIGN KEY ([Crs_Id]) REFERENCES [dbo].[Course] ([Crs_Id]) ON DELETE SET NULL ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Exam] ADD CONSTRAINT [Exam_StudFK] FOREIGN KEY ([Std_Id]) REFERENCES [dbo].[Student] ([Std_Id]) ON DELETE SET NULL ON UPDATE CASCADE
GO