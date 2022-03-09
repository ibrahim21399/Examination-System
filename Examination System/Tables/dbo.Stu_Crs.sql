CREATE TABLE [dbo].[Stu_Crs]
(
[Std_Id] [int] NOT NULL,
[Crs_Id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Stu_Crs] ADD CONSTRAINT [PK_Std_Crs] PRIMARY KEY CLUSTERED ([Std_Id], [Crs_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Stu_Crs] ADD CONSTRAINT [Crs_Stu_CrsFK] FOREIGN KEY ([Crs_Id]) REFERENCES [dbo].[Course] ([Crs_Id])
GO
ALTER TABLE [dbo].[Stu_Crs] ADD CONSTRAINT [Std_Std_CrsFK] FOREIGN KEY ([Std_Id]) REFERENCES [dbo].[Student] ([Std_Id])
GO
