USE [master]
GO
/****** Object:  Database [Lab3_QLBH]    Script Date: 8/25/2021 4:54:33 PM ******/
CREATE DATABASE [Lab3_QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Lab3_QLBH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Lab3_QLBH.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Lab3_QLBH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Lab3_QLBH_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Lab3_QLBH] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Lab3_QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Lab3_QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Lab3_QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Lab3_QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Lab3_QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Lab3_QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Lab3_QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Lab3_QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [Lab3_QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Lab3_QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Lab3_QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Lab3_QLBH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Lab3_QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Lab3_QLBH]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 8/25/2021 4:54:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Invoice](
	[invoiceID] [char](5) NOT NULL,
	[invoiceOrderDate] [datetime] NOT NULL,
	[invoiceDeliveryDate] [datetime] NOT NULL,
	[invoiceNote] [nvarchar](255) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[invoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 8/25/2021 4:54:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[orderID] [int] NOT NULL,
	[invoiceID] [char](5) NOT NULL,
	[productID] [char](5) NOT NULL,
	[productName] [nvarchar](50) NULL,
	[productUnit] [nvarchar](50) NULL,
	[orderPrice] [int] NOT NULL,
	[orderQuantity] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[invoiceID] ASC,
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/25/2021 4:54:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[productID] [char](5) NOT NULL,
	[productName] [nvarchar](50) NOT NULL,
	[productUnit] [nvarchar](50) NOT NULL,
	[productBuyPrice] [int] NULL,
	[productSellPrice] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Invoice] FOREIGN KEY([invoiceID])
REFERENCES [dbo].[Invoice] ([invoiceID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Invoice]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Product] FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([productID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO
USE [master]
GO
ALTER DATABASE [Lab3_QLBH] SET  READ_WRITE 
GO
