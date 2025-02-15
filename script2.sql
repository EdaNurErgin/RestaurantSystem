USE [master]
GO
/****** Object:  Database [CafeNew]    Script Date: 12/22/2024 5:54:20 PM ******/
CREATE DATABASE [CafeNew]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CafeNew', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CafeNew.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CafeNew_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CafeNew_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CafeNew] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CafeNew].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CafeNew] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CafeNew] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CafeNew] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CafeNew] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CafeNew] SET ARITHABORT OFF 
GO
ALTER DATABASE [CafeNew] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CafeNew] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CafeNew] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CafeNew] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CafeNew] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CafeNew] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CafeNew] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CafeNew] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CafeNew] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CafeNew] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CafeNew] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CafeNew] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CafeNew] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CafeNew] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CafeNew] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CafeNew] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CafeNew] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CafeNew] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CafeNew] SET  MULTI_USER 
GO
ALTER DATABASE [CafeNew] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CafeNew] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CafeNew] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CafeNew] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CafeNew] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CafeNew] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CafeNew] SET QUERY_STORE = ON
GO
ALTER DATABASE [CafeNew] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CafeNew]
GO
/****** Object:  Table [dbo].[Employee_Stats]    Script Date: 12/22/2024 5:54:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Stats](
	[stat_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[completed_orders] [int] NULL,
	[total_sales] [decimal](10, 2) NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK__Employee__B8A5256095781F4C] PRIMARY KEY CLUSTERED 
(
	[stat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu_Items]    Script Date: 12/22/2024 5:54:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu_Items](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NULL,
	[category] [nvarchar](50) NOT NULL,
	[price] [decimal](10, 2) NOT NULL,
	[availability] [bit] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Items]    Script Date: 12/22/2024 5:54:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Items](
	[order_item_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[unit_price] [decimal](10, 2) NOT NULL,
	[total_price] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/22/2024 5:54:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[total_amount] [decimal](10, 2) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 12/22/2024 5:54:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[report_id] [int] IDENTITY(1,1) NOT NULL,
	[report_type] [nvarchar](50) NOT NULL,
	[content] [nvarchar](max) NOT NULL,
	[generated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[report_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/22/2024 5:54:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[user_id] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[phone] [nvarchar](15) NULL,
	[address] [nvarchar](max) NULL,
	[role] [nvarchar](50) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK__Users__B9BE370FD8CFC105] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Users__AB6E6164DCF9973D] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee_Stats] ADD  CONSTRAINT [DF__Employee___compl__4F7CD00D]  DEFAULT ((0)) FOR [completed_orders]
GO
ALTER TABLE [dbo].[Employee_Stats] ADD  CONSTRAINT [DF__Employee___total__5070F446]  DEFAULT ((0.00)) FOR [total_sales]
GO
ALTER TABLE [dbo].[Menu_Items] ADD  DEFAULT ((1)) FOR [availability]
GO
ALTER TABLE [dbo].[Menu_Items] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Menu_Items] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[Reports] ADD  DEFAULT (getdate()) FOR [generated_at]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__created_a__398D8EEE]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__updated_a__3A81B327]  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[Employee_Stats]  WITH CHECK ADD  CONSTRAINT [FK__Employee___user___5165187F] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Employee_Stats] CHECK CONSTRAINT [FK__Employee___user___5165187F]
GO
ALTER TABLE [dbo].[Employee_Stats]  WITH CHECK ADD  CONSTRAINT [FK_Employee__user__5165187F] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee_Stats] CHECK CONSTRAINT [FK_Employee__user__5165187F]
GO
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([item_id])
REFERENCES [dbo].[Menu_Items] ([item_id])
GO
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([order_id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__user_id__44FF419A] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([user_id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__user_id__44FF419A]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD CHECK  (([status]='Teslim Edildi' OR [status]='Hazır' OR [status]='Hazırlanıyor'))
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD CHECK  (([report_type]='Aylık' OR [report_type]='Haftalık' OR [report_type]='Günlük'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK__Users__role__38996AB5] CHECK  (([role]='admin' OR [role]='employee' OR [role]='customer'))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK__Users__role__38996AB5]
GO
USE [master]
GO
ALTER DATABASE [CafeNew] SET  READ_WRITE 
GO
