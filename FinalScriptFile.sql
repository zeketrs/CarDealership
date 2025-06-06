USE [master]
GO
/****** Object:  Database [CarDealership]    Script Date: 6/13/2024 8:56:05 PM ******/
CREATE DATABASE [CarDealership]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarDealership', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CarDealership.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarDealership_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CarDealership_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CarDealership] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarDealership].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarDealership] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarDealership] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarDealership] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarDealership] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarDealership] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarDealership] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CarDealership] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarDealership] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarDealership] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarDealership] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarDealership] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarDealership] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarDealership] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarDealership] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarDealership] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CarDealership] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarDealership] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarDealership] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarDealership] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarDealership] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarDealership] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarDealership] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarDealership] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarDealership] SET  MULTI_USER 
GO
ALTER DATABASE [CarDealership] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarDealership] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarDealership] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarDealership] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarDealership] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarDealership] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CarDealership] SET QUERY_STORE = ON
GO
ALTER DATABASE [CarDealership] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CarDealership]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[Make] [varchar](30) NOT NULL,
	[Model] [varchar](35) NOT NULL,
	[Color] [varchar](30) NOT NULL,
	[Condition] [varchar](4) NOT NULL,
	[Price] [money] NOT NULL,
	[Age] [int] NULL,
	[Milage] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Makes]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Makes](
	[MakeID] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MakeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Models](
	[ModelID] [int] IDENTITY(1,1) NOT NULL,
	[MakeID] [int] NOT NULL,
	[Series] [varchar](35) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Role] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Inventory] ON 

INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (1, N'Honda', N'Civic', N'Silver', N'Used', 17000.0000, 4, 30000)
INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (2, N'Toyota', N'Corolla', N'Black', N'Used', 9000.0000, 14, 100000)
INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (3, N'Toyota', N'Prius', N'White', N'Used', 15000.0000, 12, 87000)
INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (4, N'Honda', N'Pilot', N'Red', N'Used', 13000.0000, 15, 35000)
INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (5, N'Toyota', N'Camry', N'Navy Blue', N'New', 25000.0000, NULL, NULL)
INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (6, N'Mitsubishi', N'Mirage', N'Forest Green', N'New', 26000.0000, NULL, NULL)
INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (7, N'Nissan', N'Sentra', N'Black', N'Used', 12000.0000, 7, 85000)
INSERT [dbo].[Inventory] ([CarID], [Make], [Model], [Color], [Condition], [Price], [Age], [Milage]) VALUES (8, N'Mitsubishi', N'Mirage', N'Purple', N'Used', 18000.0000, 3, 45000)
SET IDENTITY_INSERT [dbo].[Inventory] OFF
GO
SET IDENTITY_INSERT [dbo].[Makes] ON 

INSERT [dbo].[Makes] ([MakeID], [Manufacturer]) VALUES (1, N'Honda')
INSERT [dbo].[Makes] ([MakeID], [Manufacturer]) VALUES (2, N'Toyota')
INSERT [dbo].[Makes] ([MakeID], [Manufacturer]) VALUES (3, N'Mitsubishi')
INSERT [dbo].[Makes] ([MakeID], [Manufacturer]) VALUES (4, N'Nissan')
SET IDENTITY_INSERT [dbo].[Makes] OFF
GO
SET IDENTITY_INSERT [dbo].[Models] ON 

INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (1, 1, N'Civic')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (2, 1, N'Pilot')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (3, 1, N'Accord')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (4, 2, N'Corolla')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (5, 2, N'Prius')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (6, 2, N'Camry')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (7, 3, N'Mirage')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (8, 3, N'Outlander')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (9, 4, N'Altima')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (10, 4, N'Sentra')
INSERT [dbo].[Models] ([ModelID], [MakeID], [Series]) VALUES (11, 1, N'Passport')
SET IDENTITY_INSERT [dbo].[Models] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Role]) VALUES (1, N'Dalten', N'Password', N'Admin')
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Role]) VALUES (2, N'Ezekiel', N'Password', N'Admin')
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Role]) VALUES (3, N'John', N'Password', N'User')
INSERT [dbo].[Users] ([UserID], [UserName], [Password], [Role]) VALUES (5, N'Jane', N'Password', N'SalesRep')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT ('NEW') FOR [Condition]
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD FOREIGN KEY([MakeID])
REFERENCES [dbo].[Makes] ([MakeID])
GO
/****** Object:  StoredProcedure [dbo].[spDumpData]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spDumpData] AS

DELETE Inventory;
DBCC CHECKIDENT(Inventory, RESEED, 0);
GO
/****** Object:  StoredProcedure [dbo].[spFetchUser]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spFetchUser](
@UserName		VARCHAR (20),
@Password		VARCHAR (20)
)
AS
SELECT TOP 1 *
FROM Users
WHERE UserName = @UserName
AND Password = @Password
GO
/****** Object:  StoredProcedure [dbo].[spGetInventory]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spGetInventory]
AS
SELECT *
FROM Inventory
GO
/****** Object:  StoredProcedure [dbo].[spGetMakesOnFile]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spGetMakesOnFile]
AS
SELECT DISTINCT *
FROM Makes;
GO
/****** Object:  StoredProcedure [dbo].[spGetModelsOnFile]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spGetModelsOnFile]
AS
SELECT DISTINCT ModelID, MakeID, Series
FROM Models

--
GO
/****** Object:  StoredProcedure [dbo].[spGetUserNames]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spGetUserNames](
@Username	VARCHAR (20)
)
AS

SELECT Count(UserName)
FROM Users
WHERE UserName = @Username
GO
/****** Object:  StoredProcedure [dbo].[spInsertMake]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spInsertMake] (
@Manufacturer		VARCHAR (20)
)
AS

INSERT INTO Makes (Manufacturer)
VALUES (@Manufacturer)
GO
/****** Object:  StoredProcedure [dbo].[spInsertModel]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spInsertModel] (
@Manufacturer		VARCHAR (20),
@Series				VARCHAR(35)
)
AS
DECLARE @MakeID		INT;
	SET @MakeID = (SELECT MakeID 
						FROM Makes
						WHERE Manufacturer = @Manufacturer)

INSERT INTO Models (MakeID, Series)
VALUES (@MakeID, @Series)
GO
/****** Object:  StoredProcedure [dbo].[spInsertUser]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spInsertUser](
@UserName		VARCHAR (20),
@Password		VARCHAR (20)
)
AS
INSERT INTO Users (UserName, Password, Role)
VALUES (@UserName, @Password, 'Admin');
GO
/****** Object:  StoredProcedure [dbo].[spSaveSession]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spSaveSession](
@Make		VARCHAR(30),
@Model		VARCHAR(35),
@Color		VARCHAR(30),
@Condition	VARCHAR(4),
@Age		INT,
@Milage		INT,
@Price		MONEY)
AS
BEGIN
	INSERT INTO Inventory (Make, Model, Color, Condition, Age, Milage, Price)
		VALUES (@Make, @Model, @Color, @Condition, @Age, @Milage, @Price)
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUserRole]    Script Date: 6/13/2024 8:56:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spUpdateUserRole](
@UserName		VARCHAR (20),
@Role			VARCHAR (15)
)
AS
UPDATE Users
SET Role = @Role
WHERE UserName = @UserName;
GO
USE [master]
GO
ALTER DATABASE [CarDealership] SET  READ_WRITE 
GO
