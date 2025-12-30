
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/30/2025 11:15:45
-- Generated from EDMX file: C:\Users\FIRAT YUNUS\source\repos\TeknikServisOtomasyonu\TeknikServisOtomasyonu\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBTEKNIKSERVIS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TBL_FaturaBilgi_TBL_Cari]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_FaturaBilgi] DROP CONSTRAINT [FK_TBL_FaturaBilgi_TBL_Cari];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_FaturaBilgi_TBL_Personel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_FaturaBilgi] DROP CONSTRAINT [FK_TBL_FaturaBilgi_TBL_Personel];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_Personel_TBL_Departman1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_Personel] DROP CONSTRAINT [FK_TBL_Personel_TBL_Departman1];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_Urun_TBL_Kategori]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_Urun] DROP CONSTRAINT [FK_TBL_Urun_TBL_Kategori];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_UrunHareket_TBL_Cari]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_UrunHareket] DROP CONSTRAINT [FK_TBL_UrunHareket_TBL_Cari];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_UrunHareket_TBL_Personel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_UrunHareket] DROP CONSTRAINT [FK_TBL_UrunHareket_TBL_Personel];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_UrunHareket_TBL_Urun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_UrunHareket] DROP CONSTRAINT [FK_TBL_UrunHareket_TBL_Urun];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_UrunKabul_TBL_Cari]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_UrunKabul] DROP CONSTRAINT [FK_TBL_UrunKabul_TBL_Cari];
GO
IF OBJECT_ID(N'[dbo].[FK_TBL_UrunKabul_TBL_Personel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TBL_UrunKabul] DROP CONSTRAINT [FK_TBL_UrunKabul_TBL_Personel];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TBL_Admin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Admin];
GO
IF OBJECT_ID(N'[dbo].[TBL_Araclar]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Araclar];
GO
IF OBJECT_ID(N'[dbo].[TBL_ArızaDetay]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_ArızaDetay];
GO
IF OBJECT_ID(N'[dbo].[TBL_Cari]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Cari];
GO
IF OBJECT_ID(N'[dbo].[TBL_Departman]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Departman];
GO
IF OBJECT_ID(N'[dbo].[TBL_FaturaBilgi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_FaturaBilgi];
GO
IF OBJECT_ID(N'[dbo].[TBL_FaturaDetay]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_FaturaDetay];
GO
IF OBJECT_ID(N'[dbo].[TBL_Gider]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Gider];
GO
IF OBJECT_ID(N'[dbo].[TBL_Hakkımızda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Hakkımızda];
GO
IF OBJECT_ID(N'[dbo].[TBL_Iletisim]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Iletisim];
GO
IF OBJECT_ID(N'[dbo].[TBL_Kategori]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Kategori];
GO
IF OBJECT_ID(N'[dbo].[TBL_Notlarım]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Notlarım];
GO
IF OBJECT_ID(N'[dbo].[TBL_Personel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Personel];
GO
IF OBJECT_ID(N'[dbo].[TBL_Urun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_Urun];
GO
IF OBJECT_ID(N'[dbo].[TBL_UrunHareket]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_UrunHareket];
GO
IF OBJECT_ID(N'[dbo].[TBL_UrunKabul]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_UrunKabul];
GO
IF OBJECT_ID(N'[dbo].[TBL_UrunTakip]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBL_UrunTakip];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TBL_Admin'
CREATE TABLE [dbo].[TBL_Admin] (
    [ID] tinyint IDENTITY(1,1) NOT NULL,
    [KULLANICIAD] varchar(10)  NULL,
    [SIFRE] varchar(10)  NULL
);
GO

-- Creating table 'TBL_Araclar'
CREATE TABLE [dbo].[TBL_Araclar] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AD] varchar(50)  NULL
);
GO

-- Creating table 'TBL_ArızaDetay'
CREATE TABLE [dbo].[TBL_ArızaDetay] (
    [ARIZAID] int IDENTITY(1,1) NOT NULL,
    [ISLEM] int  NULL,
    [SORUN] varchar(250)  NULL,
    [ACIKLAMA] varchar(400)  NULL,
    [ONFİYAT] decimal(18,2)  NULL,
    [NETFİYAT] decimal(18,2)  NULL,
    [ISLEMLER] varchar(500)  NULL
);
GO

-- Creating table 'TBL_Cari'
CREATE TABLE [dbo].[TBL_Cari] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AD] varchar(30)  NULL,
    [SOYAD] varchar(30)  NULL,
    [TELEFON] varchar(20)  NULL,
    [MAIL] varchar(50)  NULL,
    [IL] varchar(20)  NULL,
    [ILCE] varchar(20)  NULL,
    [BANKA] varchar(50)  NULL,
    [VERGINO] varchar(50)  NULL,
    [VERGIDAIRESI] varchar(50)  NULL,
    [STATU] varchar(50)  NULL,
    [ADRES] varchar(250)  NULL
);
GO

-- Creating table 'TBL_Departman'
CREATE TABLE [dbo].[TBL_Departman] (
    [ID] tinyint IDENTITY(1,1) NOT NULL,
    [AD] varchar(50)  NULL,
    [ACIKLAMA] varchar(100)  NULL
);
GO

-- Creating table 'TBL_FaturaBilgi'
CREATE TABLE [dbo].[TBL_FaturaBilgi] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SERI] char(1)  NULL,
    [SIRANO] varchar(6)  NULL,
    [TARIH] datetime  NULL,
    [SAAT] char(5)  NULL,
    [VERDIDAIRE] varchar(50)  NULL,
    [CARI] int  NULL,
    [PERSONEL] smallint  NULL
);
GO

-- Creating table 'TBL_FaturaDetay'
CREATE TABLE [dbo].[TBL_FaturaDetay] (
    [FATURADETAYID] int IDENTITY(1,1) NOT NULL,
    [URUN] varchar(50)  NULL,
    [ADET] smallint  NULL,
    [FIYAT] decimal(18,2)  NULL,
    [TUTAR] decimal(18,2)  NULL,
    [FATURAID] int  NULL
);
GO

-- Creating table 'TBL_Gider'
CREATE TABLE [dbo].[TBL_Gider] (
    [GIDERID] int IDENTITY(1,1) NOT NULL,
    [GIDERACIKLAMA] varchar(50)  NULL,
    [TARIH] datetime  NULL,
    [TUTAR] decimal(18,2)  NULL
);
GO

-- Creating table 'TBL_Kategori'
CREATE TABLE [dbo].[TBL_Kategori] (
    [ID] tinyint IDENTITY(1,1) NOT NULL,
    [AD] varchar(30)  NULL
);
GO

-- Creating table 'TBL_Notlarım'
CREATE TABLE [dbo].[TBL_Notlarım] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [BASLIK] varchar(50)  NULL,
    [ICERIK] varchar(500)  NULL,
    [DURUM] bit  NULL,
    [TARIH] datetime  NULL
);
GO

-- Creating table 'TBL_Personel'
CREATE TABLE [dbo].[TBL_Personel] (
    [ID] smallint IDENTITY(1,1) NOT NULL,
    [AD] varchar(30)  NULL,
    [SOYAD] varchar(30)  NULL,
    [DEPARTMAN] tinyint  NULL,
    [FOTOGRAF] varchar(100)  NULL,
    [MAIL] varchar(50)  NULL,
    [TELEFON] varchar(20)  NULL
);
GO

-- Creating table 'TBL_Urun'
CREATE TABLE [dbo].[TBL_Urun] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AD] varchar(30)  NULL,
    [MARKA] varchar(30)  NULL,
    [ALISFİYAT] decimal(18,2)  NULL,
    [SATISFİYAT] decimal(18,2)  NULL,
    [STOK] smallint  NULL,
    [KATEGORI] tinyint  NULL,
    [DURUM] bit  NULL
);
GO

-- Creating table 'TBL_UrunHareket'
CREATE TABLE [dbo].[TBL_UrunHareket] (
    [HAREKETID] int IDENTITY(1,1) NOT NULL,
    [URUN] int  NULL,
    [MUSTERI] int  NULL,
    [PERSONEL] smallint  NULL,
    [TARIH] datetime  NULL,
    [ADET] smallint  NULL,
    [FIYAT] decimal(18,2)  NULL,
    [URUNSERINO] char(5)  NULL
);
GO

-- Creating table 'TBL_UrunKabul'
CREATE TABLE [dbo].[TBL_UrunKabul] (
    [ISLEMID] int IDENTITY(1,1) NOT NULL,
    [CARI] int  NULL,
    [PERSONEL] smallint  NULL,
    [GELISTARIHI] datetime  NULL,
    [CIKISTARİHİ] datetime  NULL,
    [URUNSERINO] char(5)  NULL,
    [URUNDURUM] bit  NULL,
    [URUNDURUMDETAY] varchar(30)  NULL
);
GO

-- Creating table 'TBL_UrunTakip'
CREATE TABLE [dbo].[TBL_UrunTakip] (
    [TAKIPID] int IDENTITY(1,1) NOT NULL,
    [TARIH] datetime  NULL,
    [ACIKLAMA] varchar(250)  NULL,
    [SERINO] char(5)  NULL
);
GO

-- Creating table 'TBL_Hakkımızda'
CREATE TABLE [dbo].[TBL_Hakkımızda] (
    [ID] tinyint IDENTITY(1,1) NOT NULL,
    [METIN] varchar(1000)  NULL
);
GO

-- Creating table 'TBL_Iletisim'
CREATE TABLE [dbo].[TBL_Iletisim] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ADSOYAD] varchar(50)  NULL,
    [MAIL] varchar(50)  NULL,
    [KONU] varchar(50)  NULL,
    [MESAJ] varchar(500)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Admin'
ALTER TABLE [dbo].[TBL_Admin]
ADD CONSTRAINT [PK_TBL_Admin]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Araclar'
ALTER TABLE [dbo].[TBL_Araclar]
ADD CONSTRAINT [PK_TBL_Araclar]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ARIZAID] in table 'TBL_ArızaDetay'
ALTER TABLE [dbo].[TBL_ArızaDetay]
ADD CONSTRAINT [PK_TBL_ArızaDetay]
    PRIMARY KEY CLUSTERED ([ARIZAID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Cari'
ALTER TABLE [dbo].[TBL_Cari]
ADD CONSTRAINT [PK_TBL_Cari]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Departman'
ALTER TABLE [dbo].[TBL_Departman]
ADD CONSTRAINT [PK_TBL_Departman]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_FaturaBilgi'
ALTER TABLE [dbo].[TBL_FaturaBilgi]
ADD CONSTRAINT [PK_TBL_FaturaBilgi]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [FATURADETAYID] in table 'TBL_FaturaDetay'
ALTER TABLE [dbo].[TBL_FaturaDetay]
ADD CONSTRAINT [PK_TBL_FaturaDetay]
    PRIMARY KEY CLUSTERED ([FATURADETAYID] ASC);
GO

-- Creating primary key on [GIDERID] in table 'TBL_Gider'
ALTER TABLE [dbo].[TBL_Gider]
ADD CONSTRAINT [PK_TBL_Gider]
    PRIMARY KEY CLUSTERED ([GIDERID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Kategori'
ALTER TABLE [dbo].[TBL_Kategori]
ADD CONSTRAINT [PK_TBL_Kategori]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Notlarım'
ALTER TABLE [dbo].[TBL_Notlarım]
ADD CONSTRAINT [PK_TBL_Notlarım]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Personel'
ALTER TABLE [dbo].[TBL_Personel]
ADD CONSTRAINT [PK_TBL_Personel]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Urun'
ALTER TABLE [dbo].[TBL_Urun]
ADD CONSTRAINT [PK_TBL_Urun]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [HAREKETID] in table 'TBL_UrunHareket'
ALTER TABLE [dbo].[TBL_UrunHareket]
ADD CONSTRAINT [PK_TBL_UrunHareket]
    PRIMARY KEY CLUSTERED ([HAREKETID] ASC);
GO

-- Creating primary key on [ISLEMID] in table 'TBL_UrunKabul'
ALTER TABLE [dbo].[TBL_UrunKabul]
ADD CONSTRAINT [PK_TBL_UrunKabul]
    PRIMARY KEY CLUSTERED ([ISLEMID] ASC);
GO

-- Creating primary key on [TAKIPID] in table 'TBL_UrunTakip'
ALTER TABLE [dbo].[TBL_UrunTakip]
ADD CONSTRAINT [PK_TBL_UrunTakip]
    PRIMARY KEY CLUSTERED ([TAKIPID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Hakkımızda'
ALTER TABLE [dbo].[TBL_Hakkımızda]
ADD CONSTRAINT [PK_TBL_Hakkımızda]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TBL_Iletisim'
ALTER TABLE [dbo].[TBL_Iletisim]
ADD CONSTRAINT [PK_TBL_Iletisim]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CARI] in table 'TBL_FaturaBilgi'
ALTER TABLE [dbo].[TBL_FaturaBilgi]
ADD CONSTRAINT [FK_TBL_FaturaBilgi_TBL_Cari]
    FOREIGN KEY ([CARI])
    REFERENCES [dbo].[TBL_Cari]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_FaturaBilgi_TBL_Cari'
CREATE INDEX [IX_FK_TBL_FaturaBilgi_TBL_Cari]
ON [dbo].[TBL_FaturaBilgi]
    ([CARI]);
GO

-- Creating foreign key on [MUSTERI] in table 'TBL_UrunHareket'
ALTER TABLE [dbo].[TBL_UrunHareket]
ADD CONSTRAINT [FK_TBL_UrunHareket_TBL_Cari]
    FOREIGN KEY ([MUSTERI])
    REFERENCES [dbo].[TBL_Cari]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_UrunHareket_TBL_Cari'
CREATE INDEX [IX_FK_TBL_UrunHareket_TBL_Cari]
ON [dbo].[TBL_UrunHareket]
    ([MUSTERI]);
GO

-- Creating foreign key on [CARI] in table 'TBL_UrunKabul'
ALTER TABLE [dbo].[TBL_UrunKabul]
ADD CONSTRAINT [FK_TBL_UrunKabul_TBL_Cari]
    FOREIGN KEY ([CARI])
    REFERENCES [dbo].[TBL_Cari]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_UrunKabul_TBL_Cari'
CREATE INDEX [IX_FK_TBL_UrunKabul_TBL_Cari]
ON [dbo].[TBL_UrunKabul]
    ([CARI]);
GO

-- Creating foreign key on [DEPARTMAN] in table 'TBL_Personel'
ALTER TABLE [dbo].[TBL_Personel]
ADD CONSTRAINT [FK_TBL_Personel_TBL_Departman1]
    FOREIGN KEY ([DEPARTMAN])
    REFERENCES [dbo].[TBL_Departman]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_Personel_TBL_Departman1'
CREATE INDEX [IX_FK_TBL_Personel_TBL_Departman1]
ON [dbo].[TBL_Personel]
    ([DEPARTMAN]);
GO

-- Creating foreign key on [PERSONEL] in table 'TBL_FaturaBilgi'
ALTER TABLE [dbo].[TBL_FaturaBilgi]
ADD CONSTRAINT [FK_TBL_FaturaBilgi_TBL_Personel]
    FOREIGN KEY ([PERSONEL])
    REFERENCES [dbo].[TBL_Personel]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_FaturaBilgi_TBL_Personel'
CREATE INDEX [IX_FK_TBL_FaturaBilgi_TBL_Personel]
ON [dbo].[TBL_FaturaBilgi]
    ([PERSONEL]);
GO

-- Creating foreign key on [KATEGORI] in table 'TBL_Urun'
ALTER TABLE [dbo].[TBL_Urun]
ADD CONSTRAINT [FK_TBL_Urun_TBL_Kategori]
    FOREIGN KEY ([KATEGORI])
    REFERENCES [dbo].[TBL_Kategori]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_Urun_TBL_Kategori'
CREATE INDEX [IX_FK_TBL_Urun_TBL_Kategori]
ON [dbo].[TBL_Urun]
    ([KATEGORI]);
GO

-- Creating foreign key on [PERSONEL] in table 'TBL_UrunHareket'
ALTER TABLE [dbo].[TBL_UrunHareket]
ADD CONSTRAINT [FK_TBL_UrunHareket_TBL_Personel]
    FOREIGN KEY ([PERSONEL])
    REFERENCES [dbo].[TBL_Personel]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_UrunHareket_TBL_Personel'
CREATE INDEX [IX_FK_TBL_UrunHareket_TBL_Personel]
ON [dbo].[TBL_UrunHareket]
    ([PERSONEL]);
GO

-- Creating foreign key on [PERSONEL] in table 'TBL_UrunKabul'
ALTER TABLE [dbo].[TBL_UrunKabul]
ADD CONSTRAINT [FK_TBL_UrunKabul_TBL_Personel]
    FOREIGN KEY ([PERSONEL])
    REFERENCES [dbo].[TBL_Personel]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_UrunKabul_TBL_Personel'
CREATE INDEX [IX_FK_TBL_UrunKabul_TBL_Personel]
ON [dbo].[TBL_UrunKabul]
    ([PERSONEL]);
GO

-- Creating foreign key on [URUN] in table 'TBL_UrunHareket'
ALTER TABLE [dbo].[TBL_UrunHareket]
ADD CONSTRAINT [FK_TBL_UrunHareket_TBL_Urun]
    FOREIGN KEY ([URUN])
    REFERENCES [dbo].[TBL_Urun]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TBL_UrunHareket_TBL_Urun'
CREATE INDEX [IX_FK_TBL_UrunHareket_TBL_Urun]
ON [dbo].[TBL_UrunHareket]
    ([URUN]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------