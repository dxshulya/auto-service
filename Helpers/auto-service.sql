USE [master]
GO
/****** Object:  Database [auto_service_db]    Script Date: 19.05.2022 10:21:34 ******/
CREATE DATABASE [auto_service_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'auto_service_db', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\auto_service_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'auto_service_db_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\auto_service_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [auto_service_db] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [auto_service_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [auto_service_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [auto_service_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [auto_service_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [auto_service_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [auto_service_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [auto_service_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [auto_service_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [auto_service_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [auto_service_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [auto_service_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [auto_service_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [auto_service_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [auto_service_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [auto_service_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [auto_service_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [auto_service_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [auto_service_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [auto_service_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [auto_service_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [auto_service_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [auto_service_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [auto_service_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [auto_service_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [auto_service_db] SET  MULTI_USER 
GO
ALTER DATABASE [auto_service_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [auto_service_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [auto_service_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [auto_service_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [auto_service_db] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'auto_service_db', N'ON'
GO
ALTER DATABASE [auto_service_db] SET QUERY_STORE = OFF
GO
USE [auto_service_db]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 19.05.2022 10:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[client_id] [int] IDENTITY(1,1) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client_Service]    Script Date: 19.05.2022 10:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Service](
	[client_id] [int] NOT NULL,
	[service_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
 CONSTRAINT [PK_Client_Service] PRIMARY KEY CLUSTERED 
(
	[client_id] ASC,
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19.05.2022 10:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[lastname] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NOT NULL,
	[zp] [money] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 19.05.2022 10:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 19.05.2022 10:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [money] NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 19.05.2022 10:21:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[role_id] [int] NOT NULL,
	[client_id] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([client_id], [surname], [name], [lastname], [telephone]) VALUES (1, N'Пономарева', N'Дарья', N'Владимировна', N'123456')
INSERT [dbo].[Client] ([client_id], [surname], [name], [lastname], [telephone]) VALUES (2, N'тест1', N'тест2', N'тест3', N'тест4')
INSERT [dbo].[Client] ([client_id], [surname], [name], [lastname], [telephone]) VALUES (3, N'Иванов', N'Иван', N'Иванович', N'1234567')
INSERT [dbo].[Client] ([client_id], [surname], [name], [lastname], [telephone]) VALUES (4, N'asdasd', N'sadsad', N'sadasd', N'asdasd')
INSERT [dbo].[Client] ([client_id], [surname], [name], [lastname], [telephone]) VALUES (5, N'bbnvbnnbvn', N'vbnvbnvb', N'vbnvnvn', N'bvnvb')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([employee_id], [surname], [name], [lastname], [telephone], [zp]) VALUES (1, N'Петров', N'Петр', N'Петров', N'1234', 10000.0000)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([role_id], [name]) VALUES (1, N'Клиент')
INSERT [dbo].[Role] ([role_id], [name]) VALUES (2, N'Сотрудник')
INSERT [dbo].[Role] ([role_id], [name]) VALUES (3, N'Админ')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([service_id], [name], [price]) VALUES (1, N'Мойка', 300.0000)
INSERT [dbo].[Service] ([service_id], [name], [price]) VALUES (2, N'Осмотр', 700.0000)
INSERT [dbo].[Service] ([service_id], [name], [price]) VALUES (3, N'Починка', 10000.0000)
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([user_id], [login], [password], [role_id], [client_id]) VALUES (1, N'sadasd', N'sadasd', 1, 4)
INSERT [dbo].[User] ([user_id], [login], [password], [role_id], [client_id]) VALUES (2, N'nvbbnvn', N'vbnvbn', 1, 5)
INSERT [dbo].[User] ([user_id], [login], [password], [role_id], [client_id]) VALUES (4, N'dara', N'123456', 3, 1)
INSERT [dbo].[User] ([user_id], [login], [password], [role_id], [client_id]) VALUES (5, N'test', N'test1', 2, 2)
INSERT [dbo].[User] ([user_id], [login], [password], [role_id], [client_id]) VALUES (6, N'ivan', N'228', 1, 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Client_Service]  WITH CHECK ADD  CONSTRAINT [FK_Client_Service_Client] FOREIGN KEY([client_id])
REFERENCES [dbo].[Client] ([client_id])
GO
ALTER TABLE [dbo].[Client_Service] CHECK CONSTRAINT [FK_Client_Service_Client]
GO
ALTER TABLE [dbo].[Client_Service]  WITH CHECK ADD  CONSTRAINT [FK_Client_Service_Employee] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[Client_Service] CHECK CONSTRAINT [FK_Client_Service_Employee]
GO
ALTER TABLE [dbo].[Client_Service]  WITH CHECK ADD  CONSTRAINT [FK_Client_Service_Service] FOREIGN KEY([service_id])
REFERENCES [dbo].[Service] ([service_id])
GO
ALTER TABLE [dbo].[Client_Service] CHECK CONSTRAINT [FK_Client_Service_Service]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Client] FOREIGN KEY([client_id])
REFERENCES [dbo].[Client] ([client_id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Client]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [auto_service_db] SET  READ_WRITE 
GO
