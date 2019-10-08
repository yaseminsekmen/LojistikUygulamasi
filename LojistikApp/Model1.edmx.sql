
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/11/2019 11:45:43
-- Generated from EDMX file: C:\Users\smart.ogrenci\Desktop\Yasemin SEKMEN\LojistikApp\LojistikApp\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Lojistik];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UrunlerSet'
CREATE TABLE [dbo].[UrunlerSet] (
    [urun_id] int IDENTITY(1,1) NOT NULL,
    [UrunAdi] nvarchar(max)  NOT NULL,
    [StokMiktari] int  NOT NULL,
    [UrunTipi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonellerSet'
CREATE TABLE [dbo].[PersonellerSet] (
    [personel_id] int IDENTITY(1,1) NOT NULL,
    [PersonelAdSoyad] nvarchar(max)  NOT NULL,
    [PersonelTel] nvarchar(max)  NOT NULL,
    [Departman_departman_id] int  NOT NULL
);
GO

-- Creating table 'DepartmanSet'
CREATE TABLE [dbo].[DepartmanSet] (
    [departman_id] int IDENTITY(1,1) NOT NULL,
    [DepartmanAdi] nvarchar(max)  NOT NULL,
    [Firmalar_firma_id] int  NOT NULL
);
GO

-- Creating table 'TasiyiciFirmalarSet'
CREATE TABLE [dbo].[TasiyiciFirmalarSet] (
    [tasiyici_id] int IDENTITY(1,1) NOT NULL,
    [TFirmaAdi] nvarchar(max)  NOT NULL,
    [TFirmaAdresi] nvarchar(max)  NOT NULL,
    [TFirmaTel] nvarchar(max)  NOT NULL,
    [TasimaSekli] nvarchar(max)  NOT NULL,
    [Firmalar_firma_id] int  NOT NULL
);
GO

-- Creating table 'UreticiFirmalarSet'
CREATE TABLE [dbo].[UreticiFirmalarSet] (
    [uretici_id] int IDENTITY(1,1) NOT NULL,
    [UFirmaAdi] nvarchar(max)  NOT NULL,
    [UFirmaAdres] nvarchar(max)  NOT NULL,
    [UFirmaTel] nvarchar(max)  NOT NULL,
    [Firmalar_firma_id] int  NOT NULL
);
GO

-- Creating table 'AliciFirmalarSet'
CREATE TABLE [dbo].[AliciFirmalarSet] (
    [alici_id] int IDENTITY(1,1) NOT NULL,
    [AFirmaAdi] nvarchar(max)  NOT NULL,
    [AFirmaAdres] nvarchar(max)  NOT NULL,
    [AFirmaTel] nvarchar(max)  NOT NULL,
    [Firmalar_firma_id] int  NOT NULL
);
GO

-- Creating table 'SevkiyatSet'
CREATE TABLE [dbo].[SevkiyatSet] (
    [sevkiyat_id] int IDENTITY(1,1) NOT NULL,
    [SevkAdi] nvarchar(max)  NOT NULL,
    [Ulke] nvarchar(max)  NOT NULL,
    [Urunler_urun_id] int  NOT NULL,
    [Firmalar_firma_id] int  NOT NULL
);
GO

-- Creating table 'FirmalarSet'
CREATE TABLE [dbo].[FirmalarSet] (
    [firma_id] int IDENTITY(1,1) NOT NULL,
    [FirmaTipi] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [urun_id] in table 'UrunlerSet'
ALTER TABLE [dbo].[UrunlerSet]
ADD CONSTRAINT [PK_UrunlerSet]
    PRIMARY KEY CLUSTERED ([urun_id] ASC);
GO

-- Creating primary key on [personel_id] in table 'PersonellerSet'
ALTER TABLE [dbo].[PersonellerSet]
ADD CONSTRAINT [PK_PersonellerSet]
    PRIMARY KEY CLUSTERED ([personel_id] ASC);
GO

-- Creating primary key on [departman_id] in table 'DepartmanSet'
ALTER TABLE [dbo].[DepartmanSet]
ADD CONSTRAINT [PK_DepartmanSet]
    PRIMARY KEY CLUSTERED ([departman_id] ASC);
GO

-- Creating primary key on [tasiyici_id] in table 'TasiyiciFirmalarSet'
ALTER TABLE [dbo].[TasiyiciFirmalarSet]
ADD CONSTRAINT [PK_TasiyiciFirmalarSet]
    PRIMARY KEY CLUSTERED ([tasiyici_id] ASC);
GO

-- Creating primary key on [uretici_id] in table 'UreticiFirmalarSet'
ALTER TABLE [dbo].[UreticiFirmalarSet]
ADD CONSTRAINT [PK_UreticiFirmalarSet]
    PRIMARY KEY CLUSTERED ([uretici_id] ASC);
GO

-- Creating primary key on [alici_id] in table 'AliciFirmalarSet'
ALTER TABLE [dbo].[AliciFirmalarSet]
ADD CONSTRAINT [PK_AliciFirmalarSet]
    PRIMARY KEY CLUSTERED ([alici_id] ASC);
GO

-- Creating primary key on [sevkiyat_id] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [PK_SevkiyatSet]
    PRIMARY KEY CLUSTERED ([sevkiyat_id] ASC);
GO

-- Creating primary key on [firma_id] in table 'FirmalarSet'
ALTER TABLE [dbo].[FirmalarSet]
ADD CONSTRAINT [PK_FirmalarSet]
    PRIMARY KEY CLUSTERED ([firma_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Departman_departman_id] in table 'PersonellerSet'
ALTER TABLE [dbo].[PersonellerSet]
ADD CONSTRAINT [FK_DepartmanPersoneller]
    FOREIGN KEY ([Departman_departman_id])
    REFERENCES [dbo].[DepartmanSet]
        ([departman_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmanPersoneller'
CREATE INDEX [IX_FK_DepartmanPersoneller]
ON [dbo].[PersonellerSet]
    ([Departman_departman_id]);
GO

-- Creating foreign key on [Firmalar_firma_id] in table 'AliciFirmalarSet'
ALTER TABLE [dbo].[AliciFirmalarSet]
ADD CONSTRAINT [FK_FirmalarAliciFirmalar]
    FOREIGN KEY ([Firmalar_firma_id])
    REFERENCES [dbo].[FirmalarSet]
        ([firma_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarAliciFirmalar'
CREATE INDEX [IX_FK_FirmalarAliciFirmalar]
ON [dbo].[AliciFirmalarSet]
    ([Firmalar_firma_id]);
GO

-- Creating foreign key on [Firmalar_firma_id] in table 'TasiyiciFirmalarSet'
ALTER TABLE [dbo].[TasiyiciFirmalarSet]
ADD CONSTRAINT [FK_FirmalarTasiyiciFirmalar]
    FOREIGN KEY ([Firmalar_firma_id])
    REFERENCES [dbo].[FirmalarSet]
        ([firma_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarTasiyiciFirmalar'
CREATE INDEX [IX_FK_FirmalarTasiyiciFirmalar]
ON [dbo].[TasiyiciFirmalarSet]
    ([Firmalar_firma_id]);
GO

-- Creating foreign key on [Firmalar_firma_id] in table 'UreticiFirmalarSet'
ALTER TABLE [dbo].[UreticiFirmalarSet]
ADD CONSTRAINT [FK_FirmalarUreticiFirmalar]
    FOREIGN KEY ([Firmalar_firma_id])
    REFERENCES [dbo].[FirmalarSet]
        ([firma_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarUreticiFirmalar'
CREATE INDEX [IX_FK_FirmalarUreticiFirmalar]
ON [dbo].[UreticiFirmalarSet]
    ([Firmalar_firma_id]);
GO

-- Creating foreign key on [Firmalar_firma_id] in table 'DepartmanSet'
ALTER TABLE [dbo].[DepartmanSet]
ADD CONSTRAINT [FK_FirmalarDepartman]
    FOREIGN KEY ([Firmalar_firma_id])
    REFERENCES [dbo].[FirmalarSet]
        ([firma_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarDepartman'
CREATE INDEX [IX_FK_FirmalarDepartman]
ON [dbo].[DepartmanSet]
    ([Firmalar_firma_id]);
GO

-- Creating foreign key on [Urunler_urun_id] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [FK_SevkiyatUrunler]
    FOREIGN KEY ([Urunler_urun_id])
    REFERENCES [dbo].[UrunlerSet]
        ([urun_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SevkiyatUrunler'
CREATE INDEX [IX_FK_SevkiyatUrunler]
ON [dbo].[SevkiyatSet]
    ([Urunler_urun_id]);
GO

-- Creating foreign key on [Firmalar_firma_id] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [FK_FirmalarSevkiyat]
    FOREIGN KEY ([Firmalar_firma_id])
    REFERENCES [dbo].[FirmalarSet]
        ([firma_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FirmalarSevkiyat'
CREATE INDEX [IX_FK_FirmalarSevkiyat]
ON [dbo].[SevkiyatSet]
    ([Firmalar_firma_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------