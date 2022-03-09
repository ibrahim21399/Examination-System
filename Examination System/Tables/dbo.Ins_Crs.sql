CREATE TABLE [dbo].[Ins_Crs]
(
[Ins_Id] [int] NOT NULL,
[Crs_Id] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ins_Crs] ADD CONSTRAINT [PK_Ins_Crs] PRIMARY KEY CLUSTERED ([Ins_Id], [Crs_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ins_Crs] ADD CONSTRAINT [Crs_Ins_CrsFK] FOREIGN KEY ([Crs_Id]) REFERENCES [dbo].[Course] ([Crs_Id])
GO
ALTER TABLE [dbo].[Ins_Crs] ADD CONSTRAINT [Ins_Ins_CrsFK] FOREIGN KEY ([Ins_Id]) REFERENCES [dbo].[Instructor] ([ins_Id])
GO
