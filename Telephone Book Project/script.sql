USE [master]
GO
/****** Object:  Database [serkansProject]    Script Date: 8.01.2023 21:07:56 ******/
CREATE DATABASE [serkansProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'serkansProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\serkansProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'serkansProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\serkansProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [serkansProject] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [serkansProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [serkansProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [serkansProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [serkansProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [serkansProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [serkansProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [serkansProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [serkansProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [serkansProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [serkansProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [serkansProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [serkansProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [serkansProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [serkansProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [serkansProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [serkansProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [serkansProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [serkansProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [serkansProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [serkansProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [serkansProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [serkansProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [serkansProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [serkansProject] SET RECOVERY FULL 
GO
ALTER DATABASE [serkansProject] SET  MULTI_USER 
GO
ALTER DATABASE [serkansProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [serkansProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [serkansProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [serkansProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [serkansProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [serkansProject] SET QUERY_STORE = OFF
GO
USE [serkansProject]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [serkansProject]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 8.01.2023 21:07:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 8.01.2023 21:07:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[phoneNum] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Language] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Login] ([username], [password]) VALUES (N'admin', N'123456')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'010133', N'Serkan ', N'Sipahi', N'05357484268', N'Avcılar', N'Male', N'English')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'020145', N'Hakan', N'Sipahi', N'05314255766', N'Sefaköy', N'Male', N'Turkish')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'010407', N'Yunus ', N'Keklik', N'05457896521', N'Beylikdüzü', N'Male', N'Turkish')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'010269', N'Yusuf', N'Şah', N'05477536215', N'Başakşehir', N'Male', N'English')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'040506', N'Ayşe ', N'Sarı', N'05324156879', N'Mecidiyeköy', N'Female', N'French')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'040503', N'Eda', N'Can', N'05467854312', N'Küçükçekmece', N'Female', N'Arabic')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'040105', N'Neslihan ', N'Ayaz', N'05451265478', N'Arnavutköy', N'Female', N'Arabic')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'010408', N'Arda', N'Küçük', N'05426874512', N'Beşiktaş', N'Male', N'English')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'045621', N'Fatma', N'Yılmaz', N'05424587964', N'Sarıyer', N'Female', N'Turkish')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'041265', N'Gülsüm', N'Çelik', N'05314567168', N'Maslak', N'Female', N'English')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'045678', N'Sıla', N'Demir', N'05365487941', N'Fatih', N'Female', N'English')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'040256', N'Ahmet', N'Önen', N'05489874165', N'Eminönü', N'Male', N'Arabic')
INSERT [dbo].[Person] ([ID], [Name], [Surname], [phoneNum], [Address], [Gender], [Language]) VALUES (N'010246', N'Ganime', N'Yıldıran', N'05421597564', N'Ataşehir', N'Female', N'French')
USE [master]
GO
ALTER DATABASE [serkansProject] SET  READ_WRITE 
GO
