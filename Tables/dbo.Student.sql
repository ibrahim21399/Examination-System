CREATE TABLE [dbo].[Student]
(
[Std_Id] [int] NOT NULL,
[Std_Full_Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Std_Username] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Std_Password] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Dept_Id] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [PK__Student__FE2B448E2C76A78C] PRIMARY KEY CLUSTERED ([Std_Id]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [UQ__Student__29549DC58277C43A] UNIQUE NONCLUSTERED ([Std_Username]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [Stud_DeptFK] FOREIGN KEY ([Dept_Id]) REFERENCES [dbo].[Department] ([Dept_Id]) ON DELETE SET NULL ON UPDATE CASCADE
GO
