USE [MyShop]
GO

/****** Object:  Table [dbo].[OrderDetails]    Script Date: 16.03.2023 21:17:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [uniqueidentifier] NOT NULL,
	[ShopItemId] [uniqueidentifier] NOT NULL,
	[Price] [money] NOT NULL,
	[Amount] [float] NOT NULL,
	[Sum] [money] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO

ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_Orders]
GO

ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_ShopItem] FOREIGN KEY([ShopItemId])
REFERENCES [dbo].[ShopItems] ([Id])
GO

ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_ShopItem]
GO

