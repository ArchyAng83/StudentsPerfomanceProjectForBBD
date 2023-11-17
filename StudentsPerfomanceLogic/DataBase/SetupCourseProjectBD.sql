/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 12.1 		*/
/*  Created On : 02-���-2022 20:43:55 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Drop Foreign Key Constraints */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Class_Teachers]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Classes] DROP CONSTRAINT [FK_Class_Teachers]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Guardians_Students_Guardians]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Guardians_Students] DROP CONSTRAINT [FK_Guardians_Students_Guardians]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Guardians_Students_Students]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Guardians_Students] DROP CONSTRAINT [FK_Guardians_Students_Students]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_HeadMasters_Users]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [HeadMasters] DROP CONSTRAINT [FK_HeadMasters_Users]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_HeadTeachers_Users]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [HeadTeachers] DROP CONSTRAINT [FK_HeadTeachers_Users]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Marks_Students]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Marks] DROP CONSTRAINT [FK_Marks_Students]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Marks_Subjects]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Marks] DROP CONSTRAINT [FK_Marks_Subjects]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Students_Class]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Students] DROP CONSTRAINT [FK_Students_Class]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Students_Users]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Students] DROP CONSTRAINT [FK_Students_Users]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Teachers_Subjects]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Teachers] DROP CONSTRAINT [FK_Teachers_Subjects]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Teachers_Users]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Teachers] DROP CONSTRAINT [FK_Teachers_Users]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[FK_Users_Roles]') AND OBJECTPROPERTY(id, N'IsForeignKey') = 1) 
ALTER TABLE [Users] DROP CONSTRAINT [FK_Users_Roles]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Classes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Classes]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Guardians]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Guardians]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Guardians_Students]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Guardians_Students]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[HeadMasters]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [HeadMasters]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[HeadTeachers]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [HeadTeachers]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Marks]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Marks]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Roles]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Roles]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Students]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Students]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Subjects]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Subjects]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Teachers]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Teachers]
GO

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Users]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Users]
GO

/* Create Tables */

CREATE TABLE [Classes]
(
	[id] int NOT NULL IDENTITY (1, 1),
	[className] nvarchar(3) UNIQUE NOT NULL,
	[classTeacherId] int NOT NULL
)
GO

CREATE TABLE [Guardians]
(
	[id] int NOT NULL IDENTITY (1, 1),
	[fullName] nvarchar(100) NOT NULL,
	[phone] varchar(20) NULL
)
GO

CREATE TABLE [Guardians_Students]
(
	[studentId] int NOT NULL,
	[guardianId] int NOT NULL
)
GO

CREATE TABLE [HeadMasters]
(
	[id] int NOT NULL,
	[firstName] nvarchar(50) NOT NULL,
	[middleName] nvarchar(50) NOT NULL,
	[lastName] nvarchar(50) NOT NULL,
	[phone] varchar(10) NULL
)
GO

CREATE TABLE [HeadTeachers]
(
	[id] int NOT NULL,
	[firstName] nvarchar(50) NOT NULL,
	[middleName] nvarchar(50) NOT NULL,
	[lastName] nvarchar(50) NOT NULL,
	[phone] varchar(10) NULL
)
GO

CREATE TABLE [Marks]
(
	[dateOfIssue] date NOT NULL,
	[subjectId] int NOT NULL,
	[studentId] int NOT NULL,
	[name] int NOT NULL
)
GO

CREATE TABLE [Roles]
(
	[id] int NOT NULL IDENTITY (1, 1),
	[name] nvarchar(50) UNIQUE NOT NULL
)
GO

CREATE TABLE [Students]
(
	[id] int NOT NULL,
	[firstName] nvarchar(50) NOT NULL,
	[middleName] nvarchar(50) NOT NULL,
	[lastName] nvarchar(50) NOT NULL,
	[dateOfBirth] date NOT NULL,
	[adress] nvarchar(100) NOT NULL,
	[classId] int NOT NULL
)
GO

CREATE TABLE [Subjects]
(
	[id] int NOT NULL IDENTITY (1, 1),
	[name] nvarchar(30) UNIQUE NOT NULL
)
GO

CREATE TABLE [Teachers]
(
	[id] int NOT NULL,
	[firstName] nvarchar(50) NOT NULL,
	[middleName] nvarchar(50) NOT NULL,
	[lastName] nvarchar(50) NOT NULL,
	[phone] varchar(10) NULL,
	[subjectId] int NOT NULL
)
GO

CREATE TABLE [Users]
(
	[id] int NOT NULL IDENTITY (1, 1),
	[login] nvarchar(50) UNIQUE NOT NULL,
	[password] nvarchar(50) NOT NULL,
	[roleId] int NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Classes] 
 ADD CONSTRAINT [PK_Class]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Class_Teachers] 
 ON [Classes] ([classTeacherId] ASC)
GO

ALTER TABLE [Guardians] 
 ADD CONSTRAINT [PK_Guardians]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [Guardians_Students] 
 ADD CONSTRAINT [PK_Guardians_Students]
	PRIMARY KEY CLUSTERED ([guardianId] ASC,[studentId] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Guardians_Students_Guardians] 
 ON [Guardians_Students] ([guardianId] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Guardians_Students_Students] 
 ON [Guardians_Students] ([studentId] ASC)
GO

ALTER TABLE [HeadMasters] 
 ADD CONSTRAINT [PK_HeadMasters]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_HeadMasters_Users] 
 ON [HeadMasters] ([id] ASC)
GO

ALTER TABLE [HeadTeachers] 
 ADD CONSTRAINT [PK_HeadTeachers]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_HeadTeachers_Users] 
 ON [HeadTeachers] ([id] ASC)
GO

ALTER TABLE [Marks] 
 ADD CONSTRAINT [PK_Marks]
	PRIMARY KEY CLUSTERED ([subjectId] ASC,[dateOfIssue] ASC,[studentId] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Marks_Students] 
 ON [Marks] ([studentId] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Marks_Subjects] 
 ON [Marks] ([subjectId] ASC)
GO

ALTER TABLE [Roles] 
 ADD CONSTRAINT [PK_Roles]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [Students] 
 ADD CONSTRAINT [PK_Students]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Students_Class] 
 ON [Students] ([classId] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Students_Users] 
 ON [Students] ([id] ASC)
GO

ALTER TABLE [Subjects] 
 ADD CONSTRAINT [PK_Subjects]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [Teachers] 
 ADD CONSTRAINT [PK_Teachers]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Teachers_Subjects] 
 ON [Teachers] ([subjectId] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Teachers_Users] 
 ON [Teachers] ([id] ASC)
GO

ALTER TABLE [Users] 
 ADD CONSTRAINT [PK_Users]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

CREATE NONCLUSTERED INDEX [IXFK_Users_Roles] 
 ON [Users] ([roleId] ASC)
GO

/* Create Foreign Key Constraints */

ALTER TABLE [Classes] ADD CONSTRAINT [FK_Class_Teachers]
	FOREIGN KEY ([classTeacherId]) REFERENCES [Teachers] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Guardians_Students] ADD CONSTRAINT [FK_Guardians_Students_Guardians]
	FOREIGN KEY ([guardianId]) REFERENCES [Guardians] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Guardians_Students] ADD CONSTRAINT [FK_Guardians_Students_Students]
	FOREIGN KEY ([studentId]) REFERENCES [Students] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [HeadMasters] ADD CONSTRAINT [FK_HeadMasters_Users]
	FOREIGN KEY ([id]) REFERENCES [Users] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [HeadTeachers] ADD CONSTRAINT [FK_HeadTeachers_Users]
	FOREIGN KEY ([id]) REFERENCES [Users] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Marks] ADD CONSTRAINT [FK_Marks_Students]
	FOREIGN KEY ([studentId]) REFERENCES [Students] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Marks] ADD CONSTRAINT [FK_Marks_Subjects]
	FOREIGN KEY ([subjectId]) REFERENCES [Subjects] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_Class]
	FOREIGN KEY ([classId]) REFERENCES [Classes] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Students] ADD CONSTRAINT [FK_Students_Users]
	FOREIGN KEY ([id]) REFERENCES [Users] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Teachers] ADD CONSTRAINT [FK_Teachers_Subjects]
	FOREIGN KEY ([subjectId]) REFERENCES [Subjects] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Teachers] ADD CONSTRAINT [FK_Teachers_Users]
	FOREIGN KEY ([id]) REFERENCES [Users] ([id]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_Roles]
	FOREIGN KEY ([roleId]) REFERENCES [Roles] ([id]) ON DELETE No Action ON UPDATE No Action
GO
