USE [RichardTutorial]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 18/03/2018 5:23:48 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cities](
	[CityId] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[CountryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 18/03/2018 5:23:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryId] [int] NOT NULL,
	[Name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 18/03/2018 5:23:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[CreationDate] [date] NULL,
	[Value] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrdersByUser]    Script Date: 18/03/2018 5:23:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersByUser](
	[OrderByUserId] [int] NOT NULL,
	[UserId] [int] NULL,
	[OrderId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderByUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 18/03/2018 5:23:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[Name] [varchar](100) NULL,
	[CityId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Cities] ([CityId], [Name], [CountryId]) VALUES (2, N'Bogota', 1)
INSERT [dbo].[Cities] ([CityId], [Name], [CountryId]) VALUES (3, N'Cali', 1)
INSERT [dbo].[Cities] ([CityId], [Name], [CountryId]) VALUES (4, N'Barranquilla', 1)
INSERT [dbo].[Countries] ([CountryId], [Name]) VALUES (1, N'Colombia')
INSERT [dbo].[Countries] ([CountryId], [Name]) VALUES (2, N'México')
INSERT [dbo].[Countries] ([CountryId], [Name]) VALUES (3, N'Estados Unidos')
INSERT [dbo].[Countries] ([CountryId], [Name]) VALUES (4, N'Argentina')
INSERT [dbo].[Countries] ([CountryId], [Name]) VALUES (5, N'Brasil')
INSERT [dbo].[Orders] ([OrderId], [CreationDate], [Value]) VALUES (1, CAST(N'2018-02-18' AS Date), 10000)
INSERT [dbo].[Orders] ([OrderId], [CreationDate], [Value]) VALUES (2, CAST(N'2018-02-18' AS Date), 10000)
INSERT [dbo].[Orders] ([OrderId], [CreationDate], [Value]) VALUES (3, CAST(N'2018-02-18' AS Date), 10000)
INSERT [dbo].[OrdersByUser] ([OrderByUserId], [UserId], [OrderId]) VALUES (1, 1, 1)
INSERT [dbo].[OrdersByUser] ([OrderByUserId], [UserId], [OrderId]) VALUES (2, 1, 2)
INSERT [dbo].[OrdersByUser] ([OrderByUserId], [UserId], [OrderId]) VALUES (3, 2, 3)
INSERT [dbo].[Users] ([UserId], [Name], [CityId]) VALUES (1, N'Richard', 2)
INSERT [dbo].[Users] ([UserId], [Name], [CityId]) VALUES (2, N'Adriana', 3)
INSERT [dbo].[Users] ([UserId], [Name], [CityId]) VALUES (3, N'Edison', 4)
INSERT [dbo].[Users] ([UserId], [Name], [CityId]) VALUES (4, N'Editado', 2)
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([CountryId])
GO
ALTER TABLE [dbo].[OrdersByUser]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrdersByUser]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([CityId])
GO
