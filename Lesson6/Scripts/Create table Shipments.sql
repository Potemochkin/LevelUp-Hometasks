USE [MyShop]
GO

/****** Object:  Table [dbo].[Shipments]    Script Date: 16.03.2023 21:20:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Shipments](
	[Id] [uniqueidentifier] NOT NULL,
	[StockId] [uniqueidentifier] NOT NULL,
	[SkuId] [uniqueidentifier] NOT NULL,
	[Amount] [float] NOT NULL,
	[DateOfShipment] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Shipments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Sku] FOREIGN KEY([SkuId])
REFERENCES [dbo].[StockKeepingUnits] ([Id])
GO

ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Sku]
GO

ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Stock] FOREIGN KEY([StockId])
REFERENCES [dbo].[Stocks] ([Id])
GO

ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Stock]
GO

