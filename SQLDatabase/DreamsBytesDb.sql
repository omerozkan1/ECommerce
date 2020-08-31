USE [master]
GO

/****** Object:  Database [DreamsBytesDb]    Script Date: 26.08.2020 07:05:53 ******/
CREATE DATABASE [DreamsBytesDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DreamsBytesDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DreamsBytesDb.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DreamsBytesDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DreamsBytesDb_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [DreamsBytesDb] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DreamsBytesDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DreamsBytesDb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET ARITHABORT OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DreamsBytesDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DreamsBytesDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET  ENABLE_BROKER 
GO

ALTER DATABASE [DreamsBytesDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DreamsBytesDb] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [DreamsBytesDb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET RECOVERY FULL 
GO

ALTER DATABASE [DreamsBytesDb] SET  MULTI_USER 
GO

ALTER DATABASE [DreamsBytesDb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DreamsBytesDb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DreamsBytesDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DreamsBytesDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [DreamsBytesDb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DreamsBytesDb] SET  READ_WRITE 
GO

