USE [Lojistik]
GO
/****** Object:  Table [dbo].[AliciFirmalarSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AliciFirmalarSet](
	[alici_id] [int] IDENTITY(1,1) NOT NULL,
	[AFirmaAdi] [nvarchar](max) NOT NULL,
	[AFirmaAdres] [nvarchar](max) NOT NULL,
	[AFirmaTel] [nvarchar](max) NOT NULL,
	[Firmalar_firma_id] [int] NOT NULL,
 CONSTRAINT [PK_AliciFirmalarSet] PRIMARY KEY CLUSTERED 
(
	[alici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DepartmanSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmanSet](
	[departman_id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmanAdi] [nvarchar](max) NOT NULL,
	[Firmalar_firma_id] [int] NOT NULL,
 CONSTRAINT [PK_DepartmanSet] PRIMARY KEY CLUSTERED 
(
	[departman_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FirmalarSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FirmalarSet](
	[firma_id] [int] IDENTITY(1,1) NOT NULL,
	[FirmaTipi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_FirmalarSet] PRIMARY KEY CLUSTERED 
(
	[firma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonellerSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonellerSet](
	[personel_id] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [nvarchar](max) NOT NULL,
	[PersonelTel] [nvarchar](max) NOT NULL,
	[Departman_departman_id] [int] NOT NULL,
 CONSTRAINT [PK_PersonellerSet] PRIMARY KEY CLUSTERED 
(
	[personel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SevkiyatSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SevkiyatSet](
	[sevkiyat_id] [int] IDENTITY(1,1) NOT NULL,
	[SevkAdi] [nvarchar](max) NOT NULL,
	[Ulke] [nvarchar](max) NOT NULL,
	[Urunler_urun_id] [int] NOT NULL,
	[Firmalar_firma_id] [int] NOT NULL,
 CONSTRAINT [PK_SevkiyatSet] PRIMARY KEY CLUSTERED 
(
	[sevkiyat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TasiyiciFirmalarSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TasiyiciFirmalarSet](
	[tasiyici_id] [int] IDENTITY(1,1) NOT NULL,
	[TFirmaAdi] [nvarchar](max) NOT NULL,
	[TFirmaAdresi] [nvarchar](max) NOT NULL,
	[TFirmaTel] [nvarchar](max) NOT NULL,
	[TasimaSekli] [nvarchar](max) NOT NULL,
	[Firmalar_firma_id] [int] NOT NULL,
 CONSTRAINT [PK_TasiyiciFirmalarSet] PRIMARY KEY CLUSTERED 
(
	[tasiyici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UreticiFirmalarSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UreticiFirmalarSet](
	[uretici_id] [int] IDENTITY(1,1) NOT NULL,
	[UFirmaAdi] [nvarchar](max) NOT NULL,
	[UFirmaAdres] [nvarchar](max) NOT NULL,
	[UFirmaTel] [nvarchar](max) NOT NULL,
	[Firmalar_firma_id] [int] NOT NULL,
 CONSTRAINT [PK_UreticiFirmalarSet] PRIMARY KEY CLUSTERED 
(
	[uretici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UrunlerSet]    Script Date: 12.04.2019 14:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunlerSet](
	[urun_id] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](max) NOT NULL,
	[StokMiktari] [int] NOT NULL,
	[UrunTipi] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_UrunlerSet] PRIMARY KEY CLUSTERED 
(
	[urun_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[AliciFirmalarSet] ON 

INSERT [dbo].[AliciFirmalarSet] ([alici_id], [AFirmaAdi], [AFirmaAdres], [AFirmaTel], [Firmalar_firma_id]) VALUES (1, N'BİM', N'İstanbul', N'02165921111', 2)
INSERT [dbo].[AliciFirmalarSet] ([alici_id], [AFirmaAdi], [AFirmaAdres], [AFirmaTel], [Firmalar_firma_id]) VALUES (2, N'xdv', N'cbhfc', N'24786', 3)
INSERT [dbo].[AliciFirmalarSet] ([alici_id], [AFirmaAdi], [AFirmaAdres], [AFirmaTel], [Firmalar_firma_id]) VALUES (4, N'dxvd', N'xdv', N'856856', 2)
SET IDENTITY_INSERT [dbo].[AliciFirmalarSet] OFF
SET IDENTITY_INSERT [dbo].[DepartmanSet] ON 

INSERT [dbo].[DepartmanSet] ([departman_id], [DepartmanAdi], [Firmalar_firma_id]) VALUES (1, N'Müdür', 1)
INSERT [dbo].[DepartmanSet] ([departman_id], [DepartmanAdi], [Firmalar_firma_id]) VALUES (2, N'Sürücü', 3)
INSERT [dbo].[DepartmanSet] ([departman_id], [DepartmanAdi], [Firmalar_firma_id]) VALUES (3, N'Muhasebe', 2)
INSERT [dbo].[DepartmanSet] ([departman_id], [DepartmanAdi], [Firmalar_firma_id]) VALUES (4, N'Müdür', 2)
INSERT [dbo].[DepartmanSet] ([departman_id], [DepartmanAdi], [Firmalar_firma_id]) VALUES (6, N'dxv', 3)
SET IDENTITY_INSERT [dbo].[DepartmanSet] OFF
SET IDENTITY_INSERT [dbo].[FirmalarSet] ON 

INSERT [dbo].[FirmalarSet] ([firma_id], [FirmaTipi]) VALUES (1, N'Üretici Firma')
INSERT [dbo].[FirmalarSet] ([firma_id], [FirmaTipi]) VALUES (2, N'Müşteri')
INSERT [dbo].[FirmalarSet] ([firma_id], [FirmaTipi]) VALUES (3, N'Taşıyıcı Firma')
INSERT [dbo].[FirmalarSet] ([firma_id], [FirmaTipi]) VALUES (5, N'fldkf')
SET IDENTITY_INSERT [dbo].[FirmalarSet] OFF
SET IDENTITY_INSERT [dbo].[PersonellerSet] ON 

INSERT [dbo].[PersonellerSet] ([personel_id], [PersonelAdSoyad], [PersonelTel], [Departman_departman_id]) VALUES (1, N'Ayşegül Akbaş', N'123456', 1)
INSERT [dbo].[PersonellerSet] ([personel_id], [PersonelAdSoyad], [PersonelTel], [Departman_departman_id]) VALUES (2, N'Yasemin SEKMEN', N'52121363', 2)
INSERT [dbo].[PersonellerSet] ([personel_id], [PersonelAdSoyad], [PersonelTel], [Departman_departman_id]) VALUES (3, N'Hande Polat', N'54545485', 4)
INSERT [dbo].[PersonellerSet] ([personel_id], [PersonelAdSoyad], [PersonelTel], [Departman_departman_id]) VALUES (4, N'Yeliz Durmuş', N'852364', 3)
INSERT [dbo].[PersonellerSet] ([personel_id], [PersonelAdSoyad], [PersonelTel], [Departman_departman_id]) VALUES (5, N'dfv', N'56385', 6)
INSERT [dbo].[PersonellerSet] ([personel_id], [PersonelAdSoyad], [PersonelTel], [Departman_departman_id]) VALUES (7, N'cbf', N'6345', 2)
SET IDENTITY_INSERT [dbo].[PersonellerSet] OFF
SET IDENTITY_INSERT [dbo].[SevkiyatSet] ON 

INSERT [dbo].[SevkiyatSet] ([sevkiyat_id], [SevkAdi], [Ulke], [Urunler_urun_id], [Firmalar_firma_id]) VALUES (1, N'Suprêmes délices', N'Türkiye', 1, 2)
INSERT [dbo].[SevkiyatSet] ([sevkiyat_id], [SevkAdi], [Ulke], [Urunler_urun_id], [Firmalar_firma_id]) VALUES (2, N'dgdfg', N'Almanya', 2, 1)
SET IDENTITY_INSERT [dbo].[SevkiyatSet] OFF
SET IDENTITY_INSERT [dbo].[TasiyiciFirmalarSet] ON 

INSERT [dbo].[TasiyiciFirmalarSet] ([tasiyici_id], [TFirmaAdi], [TFirmaAdresi], [TFirmaTel], [TasimaSekli], [Firmalar_firma_id]) VALUES (1, N'Horoz', N'İstanbul', N'0212010213', N'KaraYolu', 3)
INSERT [dbo].[TasiyiciFirmalarSet] ([tasiyici_id], [TFirmaAdi], [TFirmaAdresi], [TFirmaTel], [TasimaSekli], [Firmalar_firma_id]) VALUES (2, N'fb', N'fbfb', N'1234000', N'HavaYolu', 5)
SET IDENTITY_INSERT [dbo].[TasiyiciFirmalarSet] OFF
SET IDENTITY_INSERT [dbo].[UreticiFirmalarSet] ON 

INSERT [dbo].[UreticiFirmalarSet] ([uretici_id], [UFirmaAdi], [UFirmaAdres], [UFirmaTel], [Firmalar_firma_id]) VALUES (1, N'Gizli Bahçe', N'Muğla', N'021352552', 1)
INSERT [dbo].[UreticiFirmalarSet] ([uretici_id], [UFirmaAdi], [UFirmaAdres], [UFirmaTel], [Firmalar_firma_id]) VALUES (2, N'rgr', N'rfgr', N'4534543', 3)
INSERT [dbo].[UreticiFirmalarSet] ([uretici_id], [UFirmaAdi], [UFirmaAdres], [UFirmaTel], [Firmalar_firma_id]) VALUES (4, N'dfgf', N'dklfm', N'84855', 1)
SET IDENTITY_INSERT [dbo].[UreticiFirmalarSet] OFF
SET IDENTITY_INSERT [dbo].[UrunlerSet] ON 

INSERT [dbo].[UrunlerSet] ([urun_id], [UrunAdi], [StokMiktari], [UrunTipi]) VALUES (1, N'Çilek', 100, N'Meyve')
INSERT [dbo].[UrunlerSet] ([urun_id], [UrunAdi], [StokMiktari], [UrunTipi]) VALUES (2, N'Avakado', 250, N'Meyve')
SET IDENTITY_INSERT [dbo].[UrunlerSet] OFF
ALTER TABLE [dbo].[AliciFirmalarSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarAliciFirmalar] FOREIGN KEY([Firmalar_firma_id])
REFERENCES [dbo].[FirmalarSet] ([firma_id])
GO
ALTER TABLE [dbo].[AliciFirmalarSet] CHECK CONSTRAINT [FK_FirmalarAliciFirmalar]
GO
ALTER TABLE [dbo].[DepartmanSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarDepartman] FOREIGN KEY([Firmalar_firma_id])
REFERENCES [dbo].[FirmalarSet] ([firma_id])
GO
ALTER TABLE [dbo].[DepartmanSet] CHECK CONSTRAINT [FK_FirmalarDepartman]
GO
ALTER TABLE [dbo].[PersonellerSet]  WITH CHECK ADD  CONSTRAINT [FK_DepartmanPersoneller] FOREIGN KEY([Departman_departman_id])
REFERENCES [dbo].[DepartmanSet] ([departman_id])
GO
ALTER TABLE [dbo].[PersonellerSet] CHECK CONSTRAINT [FK_DepartmanPersoneller]
GO
ALTER TABLE [dbo].[SevkiyatSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarSevkiyat] FOREIGN KEY([Firmalar_firma_id])
REFERENCES [dbo].[FirmalarSet] ([firma_id])
GO
ALTER TABLE [dbo].[SevkiyatSet] CHECK CONSTRAINT [FK_FirmalarSevkiyat]
GO
ALTER TABLE [dbo].[SevkiyatSet]  WITH CHECK ADD  CONSTRAINT [FK_SevkiyatUrunler] FOREIGN KEY([Urunler_urun_id])
REFERENCES [dbo].[UrunlerSet] ([urun_id])
GO
ALTER TABLE [dbo].[SevkiyatSet] CHECK CONSTRAINT [FK_SevkiyatUrunler]
GO
ALTER TABLE [dbo].[TasiyiciFirmalarSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarTasiyiciFirmalar] FOREIGN KEY([Firmalar_firma_id])
REFERENCES [dbo].[FirmalarSet] ([firma_id])
GO
ALTER TABLE [dbo].[TasiyiciFirmalarSet] CHECK CONSTRAINT [FK_FirmalarTasiyiciFirmalar]
GO
ALTER TABLE [dbo].[UreticiFirmalarSet]  WITH CHECK ADD  CONSTRAINT [FK_FirmalarUreticiFirmalar] FOREIGN KEY([Firmalar_firma_id])
REFERENCES [dbo].[FirmalarSet] ([firma_id])
GO
ALTER TABLE [dbo].[UreticiFirmalarSet] CHECK CONSTRAINT [FK_FirmalarUreticiFirmalar]
GO
