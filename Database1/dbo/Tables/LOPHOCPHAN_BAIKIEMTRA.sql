﻿CREATE TABLE [dbo].[LOPHOCPHAN_BAIKIEMTRA] (
    [MaLopHP]      NVARCHAR (9) NOT NULL,
    [MaBaiKiemTra] NVARCHAR (9) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaLopHP] ASC, [MaBaiKiemTra] ASC),
    FOREIGN KEY ([MaBaiKiemTra]) REFERENCES [dbo].[BAI_KIEM_TRA] ([MaBaiKiemTra]),
    FOREIGN KEY ([MaLopHP]) REFERENCES [dbo].[LOP_HOC_PHAN] ([MaLopHP])
);

