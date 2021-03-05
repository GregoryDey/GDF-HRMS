USE [master]
GO
/****** Object:  Database [gdfhrms]    Script Date: 05/03/2021 4:58:08 pm ******/
CREATE DATABASE [gdfhrms]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gdfhrms', FILENAME = N'C:\Users\samki\gdfhrms.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gdfhrms_log', FILENAME = N'C:\Users\samki\gdfhrms_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [gdfhrms] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gdfhrms].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gdfhrms] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gdfhrms] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gdfhrms] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gdfhrms] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gdfhrms] SET ARITHABORT OFF 
GO
ALTER DATABASE [gdfhrms] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [gdfhrms] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gdfhrms] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gdfhrms] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gdfhrms] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gdfhrms] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gdfhrms] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gdfhrms] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gdfhrms] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gdfhrms] SET  ENABLE_BROKER 
GO
ALTER DATABASE [gdfhrms] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gdfhrms] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gdfhrms] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gdfhrms] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gdfhrms] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gdfhrms] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [gdfhrms] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gdfhrms] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gdfhrms] SET  MULTI_USER 
GO
ALTER DATABASE [gdfhrms] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gdfhrms] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gdfhrms] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gdfhrms] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gdfhrms] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gdfhrms] SET QUERY_STORE = OFF
GO
USE [gdfhrms]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [gdfhrms]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05/03/2021 4:58:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Lot] [nvarchar](max) NULL,
	[Street] [nvarchar](max) NULL,
	[Area] [nvarchar](max) NULL,
	[Village] [nvarchar](max) NULL,
	[Reg] [int] NOT NULL,
	[Ctry] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CareerHistories]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CareerHistories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[EmployeePIId] [int] NULL,
	[PositionId] [int] NULL,
 CONSTRAINT [PK_CareerHistories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactInfos]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactInfos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HNumber] [int] NOT NULL,
	[CNumber] [int] NOT NULL,
	[WNumber] [int] NOT NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactInfos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[EmployeePIId] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeePIs]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeePIs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NId] [int] NOT NULL,
	[RId] [int] NULL,
	[EId] [int] NULL,
	[MId] [int] NULL,
	[PId] [int] NULL,
	[CId] [int] NULL,
	[CountryId] [int] NULL,
	[AId] [int] NULL,
	[DId] [int] NULL,
	[CHId] [int] NULL,
	[RegId] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[Fname] [nvarchar](max) NULL,
	[Lname] [nvarchar](max) NULL,
	[Oname] [nvarchar](max) NULL,
	[RNumber] [int] NOT NULL,
	[Dob] [datetime2](7) NOT NULL,
	[Sex] [nvarchar](max) NULL,
	[NidNumber] [int] NOT NULL,
	[PNumber] [nvarchar](max) NULL,
	[PExpirationDate] [datetime2](7) NOT NULL,
	[TinNumber] [int] NOT NULL,
 CONSTRAINT [PK_EmployeePIs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ethnicities]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ethnicities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Ethnicities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaritalStatuses]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaritalStatuses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_MaritalStatuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nationalities]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nationalities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Nationalities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Religions]    Script Date: 05/03/2021 4:58:14 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Religions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Religions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210305193506_NewDb', N'5.0.2')
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([Id], [Lot], [Street], [Area], [Village], [Reg], [Ctry]) VALUES (1, N'Some lot', N'some street', N'some area', N'some village', 4, 1)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
SET IDENTITY_INSERT [dbo].[CareerHistories] ON 

INSERT [dbo].[CareerHistories] ([Id], [StartDate], [EndDate], [EmployeePIId], [PositionId]) VALUES (10, CAST(N'2012-09-11T00:00:00.0000000' AS DateTime2), CAST(N'2019-07-06T00:00:00.0000000' AS DateTime2), 4, 1)
SET IDENTITY_INSERT [dbo].[CareerHistories] OFF
GO
SET IDENTITY_INSERT [dbo].[ContactInfos] ON 

INSERT [dbo].[ContactInfos] ([Id], [HNumber], [CNumber], [WNumber], [Email]) VALUES (1, 1123242, 123123123, 21323123, N'some@some.com')
SET IDENTITY_INSERT [dbo].[ContactInfos] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [Name]) VALUES (1, N'Guyana')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (2, N'Brazil')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (3, N'Suriname')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (4, N'Canada')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (5, N'Russia')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (6, N'China')
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (7, N'Japan')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name], [Description], [Location], [EmployeePIId]) VALUES (1, N'Some Department', N'no description yet', N'in gdf compound', NULL)
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[EmployeePIs] ON 

INSERT [dbo].[EmployeePIs] ([Id], [NId], [RId], [EId], [MId], [PId], [CId], [CountryId], [AId], [DId], [CHId], [RegId], [Title], [Fname], [Lname], [Oname], [RNumber], [Dob], [Sex], [NidNumber], [PNumber], [PExpirationDate], [TinNumber]) VALUES (4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10, 4, N'Mr', N'Jim', N'Jones', N'Psycho', 123456, CAST(N'1978-09-10T00:00:00.0000000' AS DateTime2), N'Male', 12345678, N'A102324', CAST(N'2022-09-10T00:00:00.0000000' AS DateTime2), 11223421)
SET IDENTITY_INSERT [dbo].[EmployeePIs] OFF
GO
SET IDENTITY_INSERT [dbo].[Ethnicities] ON 

INSERT [dbo].[Ethnicities] ([Id], [Name]) VALUES (1, N'Chinese')
INSERT [dbo].[Ethnicities] ([Id], [Name]) VALUES (2, N'Portuguese')
INSERT [dbo].[Ethnicities] ([Id], [Name]) VALUES (3, N'Indian')
INSERT [dbo].[Ethnicities] ([Id], [Name]) VALUES (4, N'African')
INSERT [dbo].[Ethnicities] ([Id], [Name]) VALUES (5, N'Amerindian')
INSERT [dbo].[Ethnicities] ([Id], [Name]) VALUES (6, N'Mixed')
SET IDENTITY_INSERT [dbo].[Ethnicities] OFF
GO
SET IDENTITY_INSERT [dbo].[MaritalStatuses] ON 

INSERT [dbo].[MaritalStatuses] ([Id], [Name]) VALUES (1, N'Single')
INSERT [dbo].[MaritalStatuses] ([Id], [Name]) VALUES (2, N'Married')
INSERT [dbo].[MaritalStatuses] ([Id], [Name]) VALUES (3, N'Divorced')
INSERT [dbo].[MaritalStatuses] ([Id], [Name]) VALUES (4, N'Widowed')
INSERT [dbo].[MaritalStatuses] ([Id], [Name]) VALUES (5, N'Widower')
SET IDENTITY_INSERT [dbo].[MaritalStatuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Nationalities] ON 

INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (1, N'Guyanese')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (2, N'Chinese')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (3, N'Russian')
INSERT [dbo].[Nationalities] ([Id], [Name]) VALUES (4, N'Japanese')
SET IDENTITY_INSERT [dbo].[Nationalities] OFF
GO
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([Id], [Name]) VALUES (1, N'Cadet')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (2, N'Ensign')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (3, N'Lieutenant')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (4, N'Squadron Leader')
INSERT [dbo].[Positions] ([Id], [Name]) VALUES (5, N'Captain')
SET IDENTITY_INSERT [dbo].[Positions] OFF
GO
SET IDENTITY_INSERT [dbo].[Regions] ON 

INSERT [dbo].[Regions] ([Id], [Name]) VALUES (1, N'Barima Waini')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (2, N'Pomeroon Supernaam')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (3, N'Essequibo Islands-West Demerara')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (4, N'Demerara-Mahaica')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (5, N'Mahaica-Berbice')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (6, N'East Berbice-Corentyne')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (7, N'Cuyuni-Mazaruni')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (8, N'Potaro-Siparuni')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (9, N'Upper Takutu-Upper Essequibo')
INSERT [dbo].[Regions] ([Id], [Name]) VALUES (10, N'Upper Demerara-Berbice')
SET IDENTITY_INSERT [dbo].[Regions] OFF
GO
SET IDENTITY_INSERT [dbo].[Religions] ON 

INSERT [dbo].[Religions] ([Id], [Name]) VALUES (1, N'Christianity')
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (2, N'Hinduism')
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (3, N'Islam')
INSERT [dbo].[Religions] ([Id], [Name]) VALUES (4, N'Mormon')
SET IDENTITY_INSERT [dbo].[Religions] OFF
GO
/****** Object:  Index [IX_Addresses_Ctry]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_Ctry] ON [dbo].[Addresses]
(
	[Ctry] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Addresses_Reg]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_Reg] ON [dbo].[Addresses]
(
	[Reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CareerHistories_EmployeePIId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_CareerHistories_EmployeePIId] ON [dbo].[CareerHistories]
(
	[EmployeePIId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CareerHistories_PositionId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_CareerHistories_PositionId] ON [dbo].[CareerHistories]
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Departments_EmployeePIId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_Departments_EmployeePIId] ON [dbo].[Departments]
(
	[EmployeePIId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_AId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_AId] ON [dbo].[EmployeePIs]
(
	[AId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_CHId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_CHId] ON [dbo].[EmployeePIs]
(
	[CHId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_CId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_CId] ON [dbo].[EmployeePIs]
(
	[CId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_CountryId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_CountryId] ON [dbo].[EmployeePIs]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_DId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_DId] ON [dbo].[EmployeePIs]
(
	[DId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_EId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_EId] ON [dbo].[EmployeePIs]
(
	[EId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_MId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_MId] ON [dbo].[EmployeePIs]
(
	[MId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_NId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_NId] ON [dbo].[EmployeePIs]
(
	[NId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_PId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_PId] ON [dbo].[EmployeePIs]
(
	[PId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_RegId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_RegId] ON [dbo].[EmployeePIs]
(
	[RegId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeePIs_RId]    Script Date: 05/03/2021 4:58:15 pm ******/
CREATE NONCLUSTERED INDEX [IX_EmployeePIs_RId] ON [dbo].[EmployeePIs]
(
	[RId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Countries_Ctry] FOREIGN KEY([Ctry])
REFERENCES [dbo].[Countries] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Countries_Ctry]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Regions_Reg] FOREIGN KEY([Reg])
REFERENCES [dbo].[Regions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Regions_Reg]
GO
ALTER TABLE [dbo].[CareerHistories]  WITH CHECK ADD  CONSTRAINT [FK_CareerHistories_EmployeePIs_EmployeePIId] FOREIGN KEY([EmployeePIId])
REFERENCES [dbo].[EmployeePIs] ([Id])
GO
ALTER TABLE [dbo].[CareerHistories] CHECK CONSTRAINT [FK_CareerHistories_EmployeePIs_EmployeePIId]
GO
ALTER TABLE [dbo].[CareerHistories]  WITH CHECK ADD  CONSTRAINT [FK_CareerHistories_Positions_PositionId] FOREIGN KEY([PositionId])
REFERENCES [dbo].[Positions] ([Id])
GO
ALTER TABLE [dbo].[CareerHistories] CHECK CONSTRAINT [FK_CareerHistories_Positions_PositionId]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_EmployeePIs_EmployeePIId] FOREIGN KEY([EmployeePIId])
REFERENCES [dbo].[EmployeePIs] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_EmployeePIs_EmployeePIId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Addresses_AId] FOREIGN KEY([AId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Addresses_AId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_CareerHistories_CHId] FOREIGN KEY([CHId])
REFERENCES [dbo].[CareerHistories] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_CareerHistories_CHId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_ContactInfos_CId] FOREIGN KEY([CId])
REFERENCES [dbo].[ContactInfos] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_ContactInfos_CId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Countries_CountryId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Departments_DId] FOREIGN KEY([DId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Departments_DId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Ethnicities_EId] FOREIGN KEY([EId])
REFERENCES [dbo].[Ethnicities] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Ethnicities_EId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_MaritalStatuses_MId] FOREIGN KEY([MId])
REFERENCES [dbo].[MaritalStatuses] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_MaritalStatuses_MId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Nationalities_NId] FOREIGN KEY([NId])
REFERENCES [dbo].[Nationalities] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Nationalities_NId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Positions_PId] FOREIGN KEY([PId])
REFERENCES [dbo].[Positions] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Positions_PId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Regions_RegId] FOREIGN KEY([RegId])
REFERENCES [dbo].[Regions] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Regions_RegId]
GO
ALTER TABLE [dbo].[EmployeePIs]  WITH CHECK ADD  CONSTRAINT [FK_EmployeePIs_Religions_RId] FOREIGN KEY([RId])
REFERENCES [dbo].[Religions] ([Id])
GO
ALTER TABLE [dbo].[EmployeePIs] CHECK CONSTRAINT [FK_EmployeePIs_Religions_RId]
GO
USE [master]
GO
ALTER DATABASE [gdfhrms] SET  READ_WRITE 
GO
