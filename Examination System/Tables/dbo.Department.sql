CREATE TABLE [dbo].[Department]
(
[Dept_Id] [int] NOT NULL,
[Dept_Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Department] ADD CONSTRAINT [PK__Departme__72ABC2CCFA282087] PRIMARY KEY CLUSTERED ([Dept_Id]) ON [PRIMARY]
GO
