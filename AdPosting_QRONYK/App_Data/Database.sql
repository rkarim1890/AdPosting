USE [master]
GO
/****** Object:  Database [AdPosting_QRONYK]    Script Date: 1/17/2017 11:20:56 PM ******/
CREATE DATABASE [AdPosting_QRONYK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdPosting_QRONYK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AdPosting_QRONYK.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AdPosting_QRONYK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AdPosting_QRONYK_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AdPosting_QRONYK] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdPosting_QRONYK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AdPosting_QRONYK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET ARITHABORT OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [AdPosting_QRONYK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AdPosting_QRONYK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AdPosting_QRONYK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AdPosting_QRONYK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AdPosting_QRONYK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET RECOVERY FULL 
GO
ALTER DATABASE [AdPosting_QRONYK] SET  MULTI_USER 
GO
ALTER DATABASE [AdPosting_QRONYK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AdPosting_QRONYK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AdPosting_QRONYK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AdPosting_QRONYK] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AdPosting_QRONYK', N'ON'
GO
ALTER DATABASE [AdPosting_QRONYK] SET  READ_WRITE 
GO

/****** Object:  Table [dbo].[UserProfile]    Script Date: 1/17/2017 11:18:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_Membership]    Script Date: 1/17/2017 11:18:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Membership](
	[UserId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[ConfirmationToken] [nvarchar](128) NULL,
	[IsConfirmed] [bit] NULL,
	[LastPasswordFailureDate] [datetime] NULL,
	[PasswordFailuresSinceLastSuccess] [int] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordChangedDate] [datetime] NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordVerificationToken] [nvarchar](128) NULL,
	[PasswordVerificationTokenExpirationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_OAuthMembership]    Script Date: 1/17/2017 11:18:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_OAuthMembership](
	[Provider] [nvarchar](30) NOT NULL,
	[ProviderUserId] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Provider] ASC,
	[ProviderUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_Roles]    Script Date: 1/17/2017 11:18:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_UsersInRoles]    Script Date: 1/17/2017 11:18:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_UsersInRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__webpages__8A2B6160A01DD3C9]    Script Date: 1/17/2017 11:18:47 PM ******/
ALTER TABLE [dbo].[webpages_Roles] ADD UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [IsConfirmed]
GO
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [PasswordFailuresSinceLastSuccess]
GO
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[webpages_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_RoleId]
GO
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_UserId]
GO
USE [master]
GO
ALTER DATABASE [aspnet-AdPosting_QRONYK-20170114223334] SET  READ_ONLY 
GO
