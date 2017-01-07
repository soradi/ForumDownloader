USE [FD]
GO
/****** Object:  Table [dbo].[ProjectAttribute]    Script Date: 1/8/2017 12:17:48 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectAttribute]') AND type in (N'U'))
DROP TABLE [dbo].[ProjectAttribute]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 1/8/2017 12:17:48 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
DROP TABLE [dbo].[Project]
GO
/****** Object:  Table [dbo].[ProgramSettings]    Script Date: 1/8/2017 12:17:48 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProgramSettings]') AND type in (N'U'))
DROP TABLE [dbo].[ProgramSettings]
GO
/****** Object:  Table [dbo].[AttributeValue]    Script Date: 1/8/2017 12:17:48 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeValue]') AND type in (N'U'))
DROP TABLE [dbo].[AttributeValue]
GO
/****** Object:  Table [dbo].[Attribut]    Script Date: 1/8/2017 12:17:48 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribut]') AND type in (N'U'))
DROP TABLE [dbo].[Attribut]
GO
USE [master]
GO
/****** Object:  Database [FD]    Script Date: 1/8/2017 12:17:48 AM ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'FD')
DROP DATABASE [FD]
GO
/****** Object:  Database [FD]    Script Date: 1/8/2017 12:17:48 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'FD')
BEGIN
CREATE DATABASE [FD] ON  PRIMARY 
( NAME = N'FD', FILENAME = N'D:\FD\FD.mdf' , SIZE = 1933056KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FD_log', FILENAME = N'D:\FD\FD_log.ldf' , SIZE = 39296KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE Arabic_CI_AS
END

GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FD] SET ARITHABORT OFF 
GO
ALTER DATABASE [FD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FD] SET  MULTI_USER 
GO
ALTER DATABASE [FD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FD] SET DB_CHAINING OFF 
GO
USE [FD]
GO
/****** Object:  Table [dbo].[Attribut]    Script Date: 1/8/2017 12:17:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Attribut]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Attribut](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AttributName] [nvarchar](max) COLLATE Arabic_CI_AS NULL,
 CONSTRAINT [PK_ProjectAttribut] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AttributeValue]    Script Date: 1/8/2017 12:17:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttributeValue]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AttributeValue](
	[PageAttributeID] [int] NOT NULL,
	[PageID] [nvarchar](50) COLLATE Arabic_CI_AS NOT NULL,
	[AttributeValue] [nvarchar](max) COLLATE Arabic_CI_AS NULL,
	[id] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_AttributeValue] PRIMARY KEY CLUSTERED 
(
	[PageAttributeID] ASC,
	[PageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ProgramSettings]    Script Date: 1/8/2017 12:17:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProgramSettings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProgramSettings](
	[id] [int] NOT NULL,
	[SettingName] [nvarchar](50) COLLATE Arabic_CI_AS NULL,
	[SettingValue] [bigint] NULL,
 CONSTRAINT [PK_ProgramSettings] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Project]    Script Date: 1/8/2017 12:17:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Project](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [nvarchar](max) COLLATE Arabic_CI_AS NULL,
	[URLPattern] [nvarchar](max) COLLATE Arabic_CI_AS NULL,
	[PFrom] [bigint] NULL,
	[PTo] [bigint] NULL,
	[Tencod] [bit] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[ProjectAttribute]    Script Date: 1/8/2017 12:17:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProjectAttribute]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ProjectAttribute](
	[ProjectID] [int] NOT NULL,
	[AttributeID] [int] NOT NULL,
	[XPath] [nvarchar](max) COLLATE Arabic_CI_AS NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AttributeOrder] [int] NULL,
 CONSTRAINT [PK_ProjectAttribute] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC,
	[AttributeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
USE [master]
GO
ALTER DATABASE [FD] SET  READ_WRITE 
GO
USE [FD]
GO
INSERT [dbo].[ProgramSettings] ([id], [SettingName], [SettingValue]) VALUES (1, N'img', 0)
GO
INSERT [dbo].[ProgramSettings] ([id], [SettingName], [SettingValue]) VALUES (2, N'href', 0)
GO
