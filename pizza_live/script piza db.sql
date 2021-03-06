USE [pizza]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 11/05/2014 19:20:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stock](
	[item] [varchar](100) NOT NULL,
	[quantity] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Passwords]    Script Date: 11/05/2014 19:20:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passwords](
	[username] [nchar](10) NOT NULL,
	[password] [nchar](15) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 11/05/2014 19:20:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[order](
	[custid] [numeric](18, 0) NOT NULL,
	[orderno] [numeric](18, 0) NOT NULL,
	[itemname] [varchar](100) NOT NULL,
	[itemsize] [int] NULL,
	[itemprice] [int] NOT NULL,
	[date] [date] NOT NULL,
	[itemcateg] [varchar](100) NULL,
	[ordtype] [nchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[item]    Script Date: 11/05/2014 19:20:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[item](
	[itemid] [int] NOT NULL,
	[itemname] [varchar](100) NOT NULL,
	[itemingre] [varchar](100) NULL,
	[itemcateg] [varchar](100) NOT NULL,
	[itemprice] [int] NOT NULL,
	[itemsize] [int] NULL,
 CONSTRAINT [PK_item] PRIMARY KEY CLUSTERED 
(
	[itemid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cust]    Script Date: 11/05/2014 19:20:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cust](
	[custid] [numeric](18, 0) NOT NULL,
	[name] [nchar](100) NOT NULL,
	[address] [nchar](100) NULL,
	[phone] [numeric](11, 0) NULL,
	[email] [nchar](50) NULL
) ON [PRIMARY]
GO
