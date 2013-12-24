
CREATE TABLE [dbo].[Article](
	[article_id] [int] NOT NULL,
	[title] [nvarchar](100) NOT NULL,
	[body] [nvarchar](max) NOT NULL,
	[date_created] [datetime2](7) NOT NULL,
	[date_updated] [datetime2](7) NOT NULL,
	[author] [nvarchar](200) NOT NULL,
	[language] [nvarchar](2) NOT NULL,
	[story_id] [int] NOT NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[article_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comment]    Script Date: 12/24/2013 9:44:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](100) NOT NULL,
	[body] [nvarchar](max) NOT NULL,
	[date_created] [datetime2](7) NOT NULL,
	[date_modified] [datetime2](7) NOT NULL,
	[author] [nvarchar](100) NOT NULL,
	[article_id] [int] NOT NULL,
 CONSTRAINT [PK__Comment__3214EC07FBEC7274] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rating]    Script Date: 12/24/2013 9:44:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[user_id] [int] NOT NULL,
	[article_id] [int] NOT NULL,
	[stars] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC,
	[article_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 12/24/2013 9:44:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Article] ([article_id], [title], [body], [date_created], [date_updated], [author], [language], [story_id]) VALUES (1, N'U.S Signs Trade Deal', N'bleh bleh bleh bleh bleh bleh blhe bleh', CAST(0x070000000000F3370B AS DateTime2), CAST(0x070000000000F3370B AS DateTime2), N'Brad Urani', N'en', 1)
INSERT [dbo].[Article] ([article_id], [title], [body], [date_created], [date_updated], [author], [language], [story_id]) VALUES (2, N'Athletes Prepare for Olympics', N'U.S. althetes are busy training for Sochi', CAST(0x070000000000F3370B AS DateTime2), CAST(0x070000000000F3370B AS DateTime2), N'Fred Johnson', N'en', 2)
INSERT [dbo].[Article] ([article_id], [title], [body], [date_created], [date_updated], [author], [language], [story_id]) VALUES (3, N'LaunchCode Places 100 Jobs', N'Today we placed our 100th candidate', CAST(0x070000000000F3370B AS DateTime2), CAST(0x070000000000F3370B AS DateTime2), N'Molly Doe', N'en', 3)
INSERT [dbo].[Article] ([article_id], [title], [body], [date_created], [date_updated], [author], [language], [story_id]) VALUES (4, N'Accord en France', N'asdfasfsadfas', CAST(0x070000000000F3370B AS DateTime2), CAST(0x070000000000F3370B AS DateTime2), N'Francois', N'fr', 1)
INSERT [dbo].[Article] ([article_id], [title], [body], [date_created], [date_updated], [author], [language], [story_id]) VALUES (5, N'Fromage', N'asdfasdfasfsa', CAST(0x070000000000F3370B AS DateTime2), CAST(0x070000000000EE370B AS DateTime2), N'Sasha', N'fr', 2)
INSERT [dbo].[Article] ([article_id], [title], [body], [date_created], [date_updated], [author], [language], [story_id]) VALUES (6, N'Foie Gras', N'asdfasdfasdf', CAST(0x07000000000040C910 AS DateTime2), CAST(0x070000000000EE370B AS DateTime2), N'Vivienne', N'fr', 3)
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([id], [title], [body], [date_created], [date_modified], [author], [article_id]) VALUES (2, N'Nasty Comment', N'Your article sucks', CAST(0x070000000000F8370B AS DateTime2), CAST(0x070000000000F8370B AS DateTime2), N'Brad', 6)
INSERT [dbo].[Comment] ([id], [title], [body], [date_created], [date_modified], [author], [article_id]) VALUES (3, N'Good Comment', N'Great article', CAST(0x070000000000F8370B AS DateTime2), CAST(0x070000000000F8370B AS DateTime2), N'Ben', 6)
INSERT [dbo].[Comment] ([id], [title], [body], [date_created], [date_modified], [author], [article_id]) VALUES (4, N'Luke Warm Comment', N'Nice article', CAST(0x070000000000F8370B AS DateTime2), CAST(0x070000000000F8370B AS DateTime2), N'Gary', 6)
INSERT [dbo].[Comment] ([id], [title], [body], [date_created], [date_modified], [author], [article_id]) VALUES (5, N'Nice Article!', N'Enjoyed It', CAST(0x070000000000CE370B AS DateTime2), CAST(0x070000000000CE370B AS DateTime2), N'Susan', 2)
INSERT [dbo].[Comment] ([id], [title], [body], [date_created], [date_modified], [author], [article_id]) VALUES (6, N'Good Read', N'Liked it', CAST(0x070000000000CE370B AS DateTime2), CAST(0x070000000000CE370B AS DateTime2), N'Beth', 2)
SET IDENTITY_INSERT [dbo].[Comment] OFF
INSERT [dbo].[Rating] ([user_id], [article_id], [stars]) VALUES (1, 1, 5)
INSERT [dbo].[Rating] ([user_id], [article_id], [stars]) VALUES (1, 2, 3)
INSERT [dbo].[Rating] ([user_id], [article_id], [stars]) VALUES (2, 1, 1)
INSERT [dbo].[Rating] ([user_id], [article_id], [stars]) VALUES (2, 2, 3)
INSERT [dbo].[Rating] ([user_id], [article_id], [stars]) VALUES (3, 3, 3)
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([user_id], [first_name], [last_name], [email], [password]) VALUES (1, N'Meredith', N'Mulvey', N'meredith@gmail.com', N'password')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [email], [password]) VALUES (2, N'Joseph', N'Jones', N'joseph@gmail.com', N'password')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [email], [password]) VALUES (3, N'Jim', N'Beaux', N'jim@france.fr', N'chipre')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [email], [password]) VALUES (4, N'Mary', N'Mullenix', N'mary@gmail.com', N'password')
INSERT [dbo].[User] ([user_id], [first_name], [last_name], [email], [password]) VALUES (5, N'Jack', N'Wilson', N'jack@wilson.com', N'jack')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Article] FOREIGN KEY([article_id])
REFERENCES [dbo].[Article] ([article_id])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Article]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_Article] FOREIGN KEY([article_id])
REFERENCES [dbo].[Article] ([article_id])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_Article]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_User] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_User]
GO

