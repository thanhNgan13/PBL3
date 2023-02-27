﻿CREATE TABLE [dbo].[SINHVIEN_LOPHOCPHAN] (
    [MaHP]   NVARCHAR (9) NOT NULL,
    [MaSV]   NVARCHAR (9) NOT NULL,
    [KiHoc]  TINYINT      NULL,
    [NamHoc] TINYINT      NULL,
    PRIMARY KEY CLUSTERED ([MaHP] ASC, [MaSV] ASC),
    FOREIGN KEY ([MaHP]) REFERENCES [dbo].[LOP_HOC_PHAN] ([MaLopHP]),
    FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SINH_VIEN] ([MaSV])
);

