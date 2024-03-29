CREATE DATABASE [SimpleMarket]



USE [SimpleMarket]
GO


/****** Object:  Table [dbo].[Accounts]    Script Date: 2/29/2024 6:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[PermissionId] [tinyint] NOT NULL,
	[Email] [varchar](max) NOT NULL,
	[Phone] [varchar](max) NOT NULL,
 CONSTRAINT [PK_SignUpInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 2/29/2024 6:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_Admins_] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2/29/2024 6:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2/29/2024 6:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[IdentityImage] [varchar](max) NOT NULL,
	[Gender] [varchar](max) NOT NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firms]    Script Date: 2/29/2024 6:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Location] [varchar](max) NOT NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_Firms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 2/29/2024 6:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2/29/2024 6:44:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[FirmId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Image] [varchar](max) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 
GO
INSERT [dbo].[Accounts] ([Id], [Username], [Password], [PermissionId], [Email], [Phone]) VALUES (77, N'QE1BU1RFUg==', N'MTIz', 1, N'QURNSU5fUEVSTUlJU0lPTg==', N'Nzc0NzQ3')
GO
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 
GO
INSERT [dbo].[Admins] ([Id], [Name], [AccountId]) VALUES (31, N'QURNSU4=', 77)
GO
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 
GO
INSERT [dbo].[Permissions] ([Id], [Name]) VALUES (1, N'MASTER ADMIN')
GO
INSERT [dbo].[Permissions] ([Id], [Name]) VALUES (2, N'ADMIN')
GO
INSERT [dbo].[Permissions] ([Id], [Name]) VALUES (3, N'FIRM')
GO
INSERT [dbo].[Permissions] ([Id], [Name]) VALUES (4, N'CLIENT')
GO
SET IDENTITY_INSERT [dbo].[Permissions] OFF
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Permissions] FOREIGN KEY([PermissionId])
REFERENCES [dbo].[Permissions] ([Id])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Permissions]
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD  CONSTRAINT [FK_Admins_Accounts] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Admins] CHECK CONSTRAINT [FK_Admins_Accounts]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_Accounts] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_Accounts]
GO
ALTER TABLE [dbo].[Firms]  WITH CHECK ADD  CONSTRAINT [FK_Firms_Accounts] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Firms] CHECK CONSTRAINT [FK_Firms_Accounts]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Firms] FOREIGN KEY([FirmId])
REFERENCES [dbo].[Firms] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Firms]
GO
