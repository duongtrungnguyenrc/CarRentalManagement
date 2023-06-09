USE [master]
GO
/****** Object:  Database [CarRental]    Script Date: 5/6/2023 11:30:42 PM ******/
CREATE DATABASE [CarRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CarRental.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CarRental_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CarRental] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRental] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRental] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRental] SET  MULTI_USER 
GO
ALTER DATABASE [CarRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarRental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarRental', N'ON'
GO
ALTER DATABASE [CarRental] SET QUERY_STORE = ON
GO
ALTER DATABASE [CarRental] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CarRental]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 5/6/2023 11:30:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[car_id] [uniqueidentifier] NOT NULL,
	[car_img] [varbinary](max) NOT NULL,
	[car_name] [varchar](255) NOT NULL,
	[car_price] [float] NOT NULL,
	[engine_type] [varchar](255) NOT NULL,
	[number_of_seats] [int] NOT NULL,
	[rent_by_time] [float] NOT NULL,
	[rent_by_date] [float] NOT NULL,
	[car_year] [date] NOT NULL,
	[number_of_km] [float] NOT NULL,
	[deposit_price] [float] NOT NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[car_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/6/2023 11:30:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customer_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](255) NOT NULL,
	[phone] [varchar](10) NOT NULL,
	[address] [varchar](255) NOT NULL,
	[gender] [varchar](255) NOT NULL,
	[identifier] [varchar](20) NOT NULL,
	[driver_id] [varchar](20) NULL,
	[birth] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostContract]    Script Date: 5/6/2023 11:30:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostContract](
	[post_contract_id] [uniqueidentifier] NOT NULL,
	[contract_id] [uniqueidentifier] NULL,
	[status] [varchar](255) NOT NULL,
	[note] [varchar](255) NOT NULL,
	[extra_charge] [float] NOT NULL,
	[user_id] [uniqueidentifier] NULL,
	[payment_method] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[post_contract_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreContract]    Script Date: 5/6/2023 11:30:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreContract](
	[contract_id] [uniqueidentifier] NOT NULL,
	[rental_start_date] [date] NOT NULL,
	[rental_end_date] [date] NOT NULL,
	[contract_date] [date] NOT NULL,
	[total_prices] [float] NOT NULL,
	[payment_method] [varchar](255) NOT NULL,
	[customer_id] [uniqueidentifier] NOT NULL,
	[rental_start_time] [time](7) NULL,
	[rental_end_time] [time](7) NULL,
	[car_id] [uniqueidentifier] NULL,
	[user_id] [uniqueidentifier] NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[contract_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 5/6/2023 11:30:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[id] [uniqueidentifier] NOT NULL,
	[basic_salary] [float] NOT NULL,
	[update_time] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemAccount]    Script Date: 5/6/2023 11:30:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemAccount](
	[account_id] [uniqueidentifier] NOT NULL,
	[user_name] [varchar](255) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[role] [varchar](5) NOT NULL,
	[user_id] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemUser]    Script Date: 5/6/2023 11:30:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemUser](
	[user_id] [uniqueidentifier] NOT NULL,
	[name] [varchar](255) NOT NULL,
	[gender] [varchar](6) NOT NULL,
	[birth] [date] NOT NULL,
	[address] [varchar](255) NOT NULL,
	[identifier] [varchar](20) NOT NULL,
	[shift] [varchar](255) NOT NULL,
	[coefficients_salary] [float] NOT NULL,
	[phone] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Car] ADD  DEFAULT (newid()) FOR [car_id]
GO
ALTER TABLE [dbo].[Car] ADD  DEFAULT ('ready') FOR [status]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (newid()) FOR [customer_id]
GO
ALTER TABLE [dbo].[PostContract] ADD  DEFAULT (newid()) FOR [post_contract_id]
GO
ALTER TABLE [dbo].[PreContract] ADD  DEFAULT (newid()) FOR [contract_id]
GO
ALTER TABLE [dbo].[PreContract] ADD  DEFAULT ('Operational') FOR [status]
GO
ALTER TABLE [dbo].[Salary] ADD  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[SystemAccount] ADD  DEFAULT (newid()) FOR [account_id]
GO
ALTER TABLE [dbo].[SystemUser] ADD  DEFAULT (newid()) FOR [user_id]
GO
ALTER TABLE [dbo].[PostContract]  WITH CHECK ADD FOREIGN KEY([contract_id])
REFERENCES [dbo].[PreContract] ([contract_id])
GO
ALTER TABLE [dbo].[PostContract]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SystemUser] ([user_id])
GO
ALTER TABLE [dbo].[PreContract]  WITH CHECK ADD FOREIGN KEY([car_id])
REFERENCES [dbo].[Car] ([car_id])
GO
ALTER TABLE [dbo].[PreContract]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([customer_id])
GO
ALTER TABLE [dbo].[PreContract]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[SystemUser] ([user_id])
GO
ALTER TABLE [dbo].[SystemAccount]  WITH CHECK ADD  CONSTRAINT [FK__SystemAcc__user___47DBAE45] FOREIGN KEY([user_id])
REFERENCES [dbo].[SystemUser] ([user_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SystemAccount] CHECK CONSTRAINT [FK__SystemAcc__user___47DBAE45]
GO
USE [master]
GO
ALTER DATABASE [CarRental] SET  READ_WRITE 
GO
