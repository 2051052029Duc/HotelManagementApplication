USE [master]
GO
/****** Object:  Database [hotelDB]    Script Date: 23/04/2023 3:12:36 PM ******/
--CREATE DATABASE [hotelDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hotelDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\DESKTOP-B01JAC6\MSSQLSERVER1\MSSQL\DATA\hotelDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'hotelDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\DESKTOP-B01JAC6\MSSQLSERVER1\MSSQL\DATA\hotelDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [hotelDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hotelDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hotelDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [hotelDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [hotelDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [hotelDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [hotelDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [hotelDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [hotelDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [hotelDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [hotelDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [hotelDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [hotelDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [hotelDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [hotelDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [hotelDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [hotelDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [hotelDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [hotelDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [hotelDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [hotelDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [hotelDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [hotelDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [hotelDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [hotelDB] SET RECOVERY FULL 
GO
ALTER DATABASE [hotelDB] SET  MULTI_USER 
GO
ALTER DATABASE [hotelDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [hotelDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [hotelDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [hotelDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [hotelDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [hotelDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'hotelDB', N'ON'
GO
ALTER DATABASE [hotelDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [hotelDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [hotelDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[gender] [bit] NULL,
	[phone] [nvarchar](11) NULL,
	[address] [nvarchar](50) NULL,
	[personalId] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Floor]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Floor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetailProduct]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetailProduct](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[quantity] [int] NULL,
	[roomID] [int] NULL,
	[orderID] [int] NULL,
	[productID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetailRoom]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetailRoom](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderID] [int] NULL,
	[roomID] [int] NULL,
	[dayAt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[checkinDate] [date] NULL,
	[checkoutDate] [date] NULL,
	[totalAmount] [float] NULL,
	[numOfCus] [int] NULL,
	[status] [bit] NULL,
	[isGroup] [bit] NULL,
	[note] [nvarchar](2000) NULL,
	[customerID] [int] NULL,
	[staffID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[num] [nvarchar](50) NULL,
	[status] [bit] NULL,
	[floorId] [int] NULL,
	[typeRoomId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[gender] [bit] NULL,
	[phone] [nvarchar](11) NULL,
	[email] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[passwords] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeRoom]    Script Date: 23/04/2023 3:12:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeRoom](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [float] NULL,
	[maxCus] [int] NULL,
	[surCharge] [float] NULL,
	[qtyBed] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (1, N'Trần Quốc Hỷ', 1, N'0123456789', N'HCM', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (2, N'Trương Trọng Nghĩa', 1, N'0123456789', N'HCM', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (3, N'Mai Thị Tuyết Trinh', 0, N'0123456789', N'PT', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (4, N'Lê Minh Đức', 1, N'0123456789', N'AG', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (5, N'Trần Nhật Tiến', 1, N'0123456789', N'H', N'111111111111')
INSERT [dbo].[Customer] ([id], [name], [gender], [phone], [address], [personalId]) VALUES (6, N'Phan Lê Hồ', 1, N'0123456789', N'HCM', N'111111111111')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Floor] ON 

INSERT [dbo].[Floor] ([id], [name]) VALUES (1, N'Tầng 1')
INSERT [dbo].[Floor] ([id], [name]) VALUES (2, N'Tầng 2')
INSERT [dbo].[Floor] ([id], [name]) VALUES (3, N'Tầng 3')
SET IDENTITY_INSERT [dbo].[Floor] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [name], [price]) VALUES (1, N'Nước suối', 15000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (2, N'Fanta', 20000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (3, N'Pepsi', 20000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (4, N'Phục vụ bữa sáng', 100000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (5, N'Giặt ủi', 50000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (6, N'Spa', 300000)
INSERT [dbo].[Product] ([id], [name], [price]) VALUES (7, N'Golf', 300000)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (1, N'101', 1, 1, 1)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (2, N'102', 1, 1, 2)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (3, N'103', 1, 1, 3)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (4, N'104', 1, 1, 1)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (5, N'105', 1, 1, 2)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (6, N'106', 1, 1, 3)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (7, N'201', 1, 2, 4)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (8, N'202', 1, 2, 4)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (9, N'203', 1, 2, 2)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (10, N'204', 1, 2, 3)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (11, N'205', 1, 2, 2)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (12, N'206', 1, 2, 1)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (13, N'301', 1, 3, 1)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (14, N'302', 1, 3, 3)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (15, N'303', 1, 3, 1)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (16, N'304', 1, 3, 4)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (17, N'305', 1, 3, 3)
INSERT [dbo].[Room] ([id], [num], [status], [floorId], [typeRoomId]) VALUES (18, N'306', 1, 3, 1)
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([id], [name], [gender], [phone], [email], [username], [passwords]) VALUES (1, N'Trương Thành Đạt', 1, N'0123456789', N'dat@gmail.com', N'dat', N'1')
INSERT [dbo].[Staff] ([id], [name], [gender], [phone], [email], [username], [passwords]) VALUES (2, N'Lê Minh Đức', 1, N'0123456789', N'duc@gmail.com', N'minhduc', N'123')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeRoom] ON 

INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (1, N'STD', 300000, 2, 30000, 1)
INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (2, N'SUP', 400000, 5, 30000, 2)
INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (3, N'DLX', 500000, 8, 30000, 3)
INSERT [dbo].[TypeRoom] ([id], [name], [price], [maxCus], [surCharge], [qtyBed]) VALUES (4, N'SUT', 600000, 8, 50000, 3)
SET IDENTITY_INSERT [dbo].[TypeRoom] OFF
GO
ALTER TABLE [dbo].[Room] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[OrderDetailProduct]  WITH CHECK ADD FOREIGN KEY([orderID])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[OrderDetailProduct]  WITH CHECK ADD FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[OrderDetailProduct]  WITH CHECK ADD FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([id])
GO
ALTER TABLE [dbo].[OrderDetailRoom]  WITH CHECK ADD FOREIGN KEY([orderID])
REFERENCES [dbo].[Orders] ([id])
GO
ALTER TABLE [dbo].[OrderDetailRoom]  WITH CHECK ADD FOREIGN KEY([roomID])
REFERENCES [dbo].[Room] ([id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([staffID])
REFERENCES [dbo].[Staff] ([id])
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD FOREIGN KEY([floorId])
REFERENCES [dbo].[Floor] ([id])
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD FOREIGN KEY([typeRoomId])
REFERENCES [dbo].[TypeRoom] ([id])
GO
USE [master]
GO
ALTER DATABASE [hotelDB] SET  READ_WRITE 
GO
