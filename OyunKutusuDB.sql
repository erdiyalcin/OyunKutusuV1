USE [OyunKutusuDB]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 5.01.2022 15:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[eposta] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oyun]    Script Date: 5.01.2022 15:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oyun](
	[oyunID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Oyun] PRIMARY KEY CLUSTERED 
(
	[oyunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skor]    Script Date: 5.01.2022 15:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skor](
	[skorID] [int] IDENTITY(1,1) NOT NULL,
	[oyunID] [int] NULL,
	[kullaniciID] [int] NULL,
	[puan] [float] NULL,
	[tarih] [smalldatetime] NULL,
	[sure] [int] NULL,
 CONSTRAINT [PK_Skor] PRIMARY KEY CLUSTERED 
(
	[skorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 
GO
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre]) VALUES (1, N'Erdi', N'YALÇIN', N'erdi@gmail.com', N'1')
GO
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre]) VALUES (2, N'Hakan', N'ŞEKER', N'hakan@gmail.com', N'1')
GO
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre]) VALUES (3, N'Mete', N'BUDUR', N'mete@gmail.com', N'1')
GO
INSERT [dbo].[Kullanici] ([kullaniciID], [ad], [soyad], [eposta], [sifre]) VALUES (4, N'Ali', N'YALÇIN', N'ali@gmail.com', N'1')
GO
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Oyun] ON 
GO
INSERT [dbo].[Oyun] ([oyunID], [ad]) VALUES (1, N'Sayı Tahmin Oyunu')
GO
SET IDENTITY_INSERT [dbo].[Oyun] OFF
GO
SET IDENTITY_INSERT [dbo].[Skor] ON 
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (1, 1, 1, 32, CAST(N'2022-01-04T16:24:00' AS SmallDateTime), 21)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (2, 1, 2, 32, CAST(N'2022-01-04T16:27:00' AS SmallDateTime), 26)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (3, 1, 3, 75, CAST(N'2022-01-04T16:28:00' AS SmallDateTime), 9)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (4, 1, 2, 20, CAST(N'2022-01-04T16:29:00' AS SmallDateTime), 29)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (5, 1, 3, 150, CAST(N'2022-01-04T16:29:00' AS SmallDateTime), 5)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (6, 1, 2, 60, CAST(N'2022-01-04T16:30:00' AS SmallDateTime), 10)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (7, 1, 2, 60, CAST(N'2022-01-04T16:30:00' AS SmallDateTime), 10)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (8, 1, 2, 6, CAST(N'2022-01-04T16:32:00' AS SmallDateTime), 36)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (9, 1, 2, 32, CAST(N'2022-01-04T16:33:00' AS SmallDateTime), 19)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (10, 1, 4, 14, CAST(N'2022-01-04T19:20:00' AS SmallDateTime), 22)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (11, 1, 4, 11, CAST(N'2022-01-04T19:20:00' AS SmallDateTime), 22)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (12, 1, 4, 8, CAST(N'2022-01-04T19:20:00' AS SmallDateTime), 22)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (13, 1, 4, 28, CAST(N'2022-01-04T19:22:00' AS SmallDateTime), 15)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (14, 1, 4, 11, CAST(N'2022-01-04T19:23:00' AS SmallDateTime), 22)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (15, 1, 4, 0.8, CAST(N'2022-01-04T19:24:00' AS SmallDateTime), 41)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (16, 1, 4, 60, CAST(N'2022-01-04T19:26:00' AS SmallDateTime), 9)
GO
INSERT [dbo].[Skor] ([skorID], [oyunID], [kullaniciID], [puan], [tarih], [sure]) VALUES (17, 1, 4, 99, CAST(N'2022-01-04T19:26:00' AS SmallDateTime), 6)
GO
SET IDENTITY_INSERT [dbo].[Skor] OFF
GO
ALTER TABLE [dbo].[Skor]  WITH CHECK ADD  CONSTRAINT [FK_Skor_Kullanici] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[Skor] CHECK CONSTRAINT [FK_Skor_Kullanici]
GO
ALTER TABLE [dbo].[Skor]  WITH CHECK ADD  CONSTRAINT [FK_Skor_Oyun] FOREIGN KEY([oyunID])
REFERENCES [dbo].[Oyun] ([oyunID])
GO
ALTER TABLE [dbo].[Skor] CHECK CONSTRAINT [FK_Skor_Oyun]
GO
