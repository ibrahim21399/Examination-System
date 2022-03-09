CREATE TABLE [dbo].[Instructor]
(
[ins_Id] [int] NOT NULL,
[ins_Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[ins_Username] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[ins_password] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Dept_Id] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Instructor] ADD CONSTRAINT [PK__Instruct__9CB029180EEA18B7] PRIMARY KEY CLUSTERED ([ins_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Instructor] ADD CONSTRAINT [UQ__Instruct__C868DD25F81E151D] UNIQUE NONCLUSTERED ([ins_Username]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Instructor] ADD CONSTRAINT [Ins_DeptFK] FOREIGN KEY ([Dept_Id]) REFERENCES [dbo].[Department] ([Dept_Id]) ON DELETE SET NULL ON UPDATE CASCADE
GO
