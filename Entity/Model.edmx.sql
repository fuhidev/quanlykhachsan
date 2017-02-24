
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/01/2016 23:52:16
-- Generated from EDMX file: d:\documents\visual studio 2013\Projects\HotelManagement\Entity\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QuanLyKhachSan];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[QuanLyKhachSanModelStoreContainer].[FK_ChiTietDichVu_DichVu]', 'F') IS NOT NULL
    ALTER TABLE [QuanLyKhachSanModelStoreContainer].[ChiTietDichVu] DROP CONSTRAINT [FK_ChiTietDichVu_DichVu];
GO
IF OBJECT_ID(N'[QuanLyKhachSanModelStoreContainer].[FK_ChiTietDichVu_ThuePhong]', 'F') IS NOT NULL
    ALTER TABLE [QuanLyKhachSanModelStoreContainer].[ChiTietDichVu] DROP CONSTRAINT [FK_ChiTietDichVu_ThuePhong];
GO
IF OBJECT_ID(N'[QuanLyKhachSanModelStoreContainer].[FK_ChiTietThuePhong_KhachHang]', 'F') IS NOT NULL
    ALTER TABLE [QuanLyKhachSanModelStoreContainer].[ChiTietThuePhong] DROP CONSTRAINT [FK_ChiTietThuePhong_KhachHang];
GO
IF OBJECT_ID(N'[QuanLyKhachSanModelStoreContainer].[FK_ChiTietThuePhong_ThuePhong]', 'F') IS NOT NULL
    ALTER TABLE [QuanLyKhachSanModelStoreContainer].[ChiTietThuePhong] DROP CONSTRAINT [FK_ChiTietThuePhong_ThuePhong];
GO
IF OBJECT_ID(N'[dbo].[FK_DichVu_LoaiDichVu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DichVu] DROP CONSTRAINT [FK_DichVu_LoaiDichVu];
GO
IF OBJECT_ID(N'[dbo].[FK_GiaTien_GiaTien]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GiaTien] DROP CONSTRAINT [FK_GiaTien_GiaTien];
GO
IF OBJECT_ID(N'[dbo].[FK_HoaDon_HoaDon]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK_HoaDon_HoaDon];
GO
IF OBJECT_ID(N'[dbo].[FK_HoaDon_NhanVien]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK_HoaDon_NhanVien];
GO
IF OBJECT_ID(N'[dbo].[FK_HoaDon_ThuePhong]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HoaDon] DROP CONSTRAINT [FK_HoaDon_ThuePhong];
GO
IF OBJECT_ID(N'[dbo].[FK_Phong_LoaiPhong]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Phong] DROP CONSTRAINT [FK_Phong_LoaiPhong];
GO
IF OBJECT_ID(N'[dbo].[FK_ThuePhong_Phong]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ThuePhong] DROP CONSTRAINT [FK_ThuePhong_Phong];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DichVu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DichVu];
GO
IF OBJECT_ID(N'[dbo].[GiaTien]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GiaTien];
GO
IF OBJECT_ID(N'[dbo].[HoaDon]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HoaDon];
GO
IF OBJECT_ID(N'[dbo].[KhachHang]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KhachHang];
GO
IF OBJECT_ID(N'[dbo].[LoaiDichVu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoaiDichVu];
GO
IF OBJECT_ID(N'[dbo].[LoaiPhong]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoaiPhong];
GO
IF OBJECT_ID(N'[dbo].[NhanVien]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NhanVien];
GO
IF OBJECT_ID(N'[dbo].[Phong]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Phong];
GO
IF OBJECT_ID(N'[dbo].[ThuePhong]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ThuePhong];
GO
IF OBJECT_ID(N'[QuanLyKhachSanModelStoreContainer].[ChiTietDichVu]', 'U') IS NOT NULL
    DROP TABLE [QuanLyKhachSanModelStoreContainer].[ChiTietDichVu];
GO
IF OBJECT_ID(N'[QuanLyKhachSanModelStoreContainer].[ChiTietThuePhong]', 'U') IS NOT NULL
    DROP TABLE [QuanLyKhachSanModelStoreContainer].[ChiTietThuePhong];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DichVus'
CREATE TABLE [dbo].[DichVus] (
    [madichvu] int IDENTITY(1,1) NOT NULL,
    [tendichvu] nvarchar(50)  NULL,
    [dongia] decimal(19,4)  NULL,
    [soluong] int  NULL,
    [loaidichvu] int  NOT NULL
);
GO

-- Creating table 'GiaTiens'
CREATE TABLE [dbo].[GiaTiens] (
    [id] int IDENTITY(1,1) NOT NULL,
    [loaiphong] int  NOT NULL,
    [giatien1] decimal(19,4)  NULL,
    [loaigiatien] nvarchar(50)  NULL
);
GO

-- Creating table 'HoaDons'
CREATE TABLE [dbo].[HoaDons] (
    [mahoadon] bigint IDENTITY(1,1) NOT NULL,
    [mathuephong] int  NOT NULL,
    [tongtien] decimal(19,4)  NULL,
    [tiendatra] decimal(19,4)  NULL,
    [tienconthua] decimal(19,4)  NULL,
    [ngaythanhtoan] datetime  NULL,
    [tongtiendichvu] decimal(19,4)  NULL,
    [tongtienphong] decimal(19,4)  NULL,
    [nhanvien] int  NOT NULL,
    [khachhang] varchar(10)  NOT NULL
);
GO

-- Creating table 'KhachHangs'
CREATE TABLE [dbo].[KhachHangs] (
    [id] varchar(10)  NOT NULL,
    [ten] nvarchar(50)  NULL,
    [sodienthoai] varchar(11)  NULL,
    [email] varchar(50)  NULL
);
GO

-- Creating table 'LoaiDichVus'
CREATE TABLE [dbo].[LoaiDichVus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [tendichvu] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LoaiPhongs'
CREATE TABLE [dbo].[LoaiPhongs] (
    [maloaiphong] int IDENTITY(1,1) NOT NULL,
    [tenLoaiPhong] nvarchar(50)  NULL,
    [soLuongGiuong] int  NULL
);
GO

-- Creating table 'NhanViens'
CREATE TABLE [dbo].[NhanViens] (
    [id] int IDENTITY(1,1) NOT NULL,
    [ten] nvarchar(50)  NOT NULL,
    [taikhoan] varchar(50)  NULL,
    [matkhau] varchar(50)  NULL
);
GO

-- Creating table 'Phongs'
CREATE TABLE [dbo].[Phongs] (
    [id] int IDENTITY(1,1) NOT NULL,
    [loaiphong] int  NOT NULL,
    [tenphong] nvarchar(50)  NULL,
    [tinhtrang] int  NULL,
    [tang] int  NULL
);
GO

-- Creating table 'ThuePhongs'
CREATE TABLE [dbo].[ThuePhongs] (
    [mathuephong] int IDENTITY(1,1) NOT NULL,
    [maphong] int  NOT NULL,
    [ngaythue] datetime  NULL,
    [ngaytra] datetime  NULL
);
GO

-- Creating table 'ChiTietDichVus'
CREATE TABLE [dbo].[ChiTietDichVus] (
    [mathuephong] int IDENTITY(1,1) NOT NULL,
    [dichvu] int  NOT NULL,
    [thoigian] datetime  NULL,
    [soluong] int  NULL
);
GO

-- Creating table 'ChiTietThuePhongs'
CREATE TABLE [dbo].[ChiTietThuePhongs] (
    [mathuephong] int  NOT NULL,
    [khachhang] varchar(10)  NOT NULL,
    [vaitro] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [madichvu] in table 'DichVus'
ALTER TABLE [dbo].[DichVus]
ADD CONSTRAINT [PK_DichVus]
    PRIMARY KEY CLUSTERED ([madichvu] ASC);
GO

-- Creating primary key on [id] in table 'GiaTiens'
ALTER TABLE [dbo].[GiaTiens]
ADD CONSTRAINT [PK_GiaTiens]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [mahoadon] in table 'HoaDons'
ALTER TABLE [dbo].[HoaDons]
ADD CONSTRAINT [PK_HoaDons]
    PRIMARY KEY CLUSTERED ([mahoadon] ASC);
GO

-- Creating primary key on [id] in table 'KhachHangs'
ALTER TABLE [dbo].[KhachHangs]
ADD CONSTRAINT [PK_KhachHangs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'LoaiDichVus'
ALTER TABLE [dbo].[LoaiDichVus]
ADD CONSTRAINT [PK_LoaiDichVus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [maloaiphong] in table 'LoaiPhongs'
ALTER TABLE [dbo].[LoaiPhongs]
ADD CONSTRAINT [PK_LoaiPhongs]
    PRIMARY KEY CLUSTERED ([maloaiphong] ASC);
GO

-- Creating primary key on [id] in table 'NhanViens'
ALTER TABLE [dbo].[NhanViens]
ADD CONSTRAINT [PK_NhanViens]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Phongs'
ALTER TABLE [dbo].[Phongs]
ADD CONSTRAINT [PK_Phongs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [mathuephong] in table 'ThuePhongs'
ALTER TABLE [dbo].[ThuePhongs]
ADD CONSTRAINT [PK_ThuePhongs]
    PRIMARY KEY CLUSTERED ([mathuephong] ASC);
GO

-- Creating primary key on [mathuephong], [dichvu] in table 'ChiTietDichVus'
ALTER TABLE [dbo].[ChiTietDichVus]
ADD CONSTRAINT [PK_ChiTietDichVus]
    PRIMARY KEY CLUSTERED ([mathuephong], [dichvu] ASC);
GO

-- Creating primary key on [mathuephong], [khachhang] in table 'ChiTietThuePhongs'
ALTER TABLE [dbo].[ChiTietThuePhongs]
ADD CONSTRAINT [PK_ChiTietThuePhongs]
    PRIMARY KEY CLUSTERED ([mathuephong], [khachhang] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [dichvu] in table 'ChiTietDichVus'
ALTER TABLE [dbo].[ChiTietDichVus]
ADD CONSTRAINT [FK_ChiTietDichVu_DichVu]
    FOREIGN KEY ([dichvu])
    REFERENCES [dbo].[DichVus]
        ([madichvu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChiTietDichVu_DichVu'
CREATE INDEX [IX_FK_ChiTietDichVu_DichVu]
ON [dbo].[ChiTietDichVus]
    ([dichvu]);
GO

-- Creating foreign key on [loaidichvu] in table 'DichVus'
ALTER TABLE [dbo].[DichVus]
ADD CONSTRAINT [FK_DichVu_LoaiDichVu]
    FOREIGN KEY ([loaidichvu])
    REFERENCES [dbo].[LoaiDichVus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DichVu_LoaiDichVu'
CREATE INDEX [IX_FK_DichVu_LoaiDichVu]
ON [dbo].[DichVus]
    ([loaidichvu]);
GO

-- Creating foreign key on [loaiphong] in table 'GiaTiens'
ALTER TABLE [dbo].[GiaTiens]
ADD CONSTRAINT [FK_GiaTien_GiaTien]
    FOREIGN KEY ([loaiphong])
    REFERENCES [dbo].[LoaiPhongs]
        ([maloaiphong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GiaTien_GiaTien'
CREATE INDEX [IX_FK_GiaTien_GiaTien]
ON [dbo].[GiaTiens]
    ([loaiphong]);
GO

-- Creating foreign key on [khachhang] in table 'HoaDons'
ALTER TABLE [dbo].[HoaDons]
ADD CONSTRAINT [FK_HoaDon_HoaDon]
    FOREIGN KEY ([khachhang])
    REFERENCES [dbo].[KhachHangs]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HoaDon_HoaDon'
CREATE INDEX [IX_FK_HoaDon_HoaDon]
ON [dbo].[HoaDons]
    ([khachhang]);
GO

-- Creating foreign key on [nhanvien] in table 'HoaDons'
ALTER TABLE [dbo].[HoaDons]
ADD CONSTRAINT [FK_HoaDon_NhanVien]
    FOREIGN KEY ([nhanvien])
    REFERENCES [dbo].[NhanViens]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HoaDon_NhanVien'
CREATE INDEX [IX_FK_HoaDon_NhanVien]
ON [dbo].[HoaDons]
    ([nhanvien]);
GO

-- Creating foreign key on [mathuephong] in table 'HoaDons'
ALTER TABLE [dbo].[HoaDons]
ADD CONSTRAINT [FK_HoaDon_ThuePhong]
    FOREIGN KEY ([mathuephong])
    REFERENCES [dbo].[ThuePhongs]
        ([mathuephong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HoaDon_ThuePhong'
CREATE INDEX [IX_FK_HoaDon_ThuePhong]
ON [dbo].[HoaDons]
    ([mathuephong]);
GO

-- Creating foreign key on [khachhang] in table 'ChiTietThuePhongs'
ALTER TABLE [dbo].[ChiTietThuePhongs]
ADD CONSTRAINT [FK_ChiTietThuePhong_KhachHang]
    FOREIGN KEY ([khachhang])
    REFERENCES [dbo].[KhachHangs]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ChiTietThuePhong_KhachHang'
CREATE INDEX [IX_FK_ChiTietThuePhong_KhachHang]
ON [dbo].[ChiTietThuePhongs]
    ([khachhang]);
GO

-- Creating foreign key on [loaiphong] in table 'Phongs'
ALTER TABLE [dbo].[Phongs]
ADD CONSTRAINT [FK_Phong_LoaiPhong]
    FOREIGN KEY ([loaiphong])
    REFERENCES [dbo].[LoaiPhongs]
        ([maloaiphong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Phong_LoaiPhong'
CREATE INDEX [IX_FK_Phong_LoaiPhong]
ON [dbo].[Phongs]
    ([loaiphong]);
GO

-- Creating foreign key on [maphong] in table 'ThuePhongs'
ALTER TABLE [dbo].[ThuePhongs]
ADD CONSTRAINT [FK_ThuePhong_Phong]
    FOREIGN KEY ([maphong])
    REFERENCES [dbo].[Phongs]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ThuePhong_Phong'
CREATE INDEX [IX_FK_ThuePhong_Phong]
ON [dbo].[ThuePhongs]
    ([maphong]);
GO

-- Creating foreign key on [mathuephong] in table 'ChiTietDichVus'
ALTER TABLE [dbo].[ChiTietDichVus]
ADD CONSTRAINT [FK_ChiTietDichVu_ThuePhong]
    FOREIGN KEY ([mathuephong])
    REFERENCES [dbo].[ThuePhongs]
        ([mathuephong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [mathuephong] in table 'ChiTietThuePhongs'
ALTER TABLE [dbo].[ChiTietThuePhongs]
ADD CONSTRAINT [FK_ChiTietThuePhong_ThuePhong]
    FOREIGN KEY ([mathuephong])
    REFERENCES [dbo].[ThuePhongs]
        ([mathuephong])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------