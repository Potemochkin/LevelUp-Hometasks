USE [MyShop]
GO

/****** Object:  Table [dbo].[Prices]    Script Date: 16.03.2023 21:20:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prices](
	[ShopItemId] [uniqueidentifier] NOT NULL,
	[DateTime] [datetime2](7) NOT NULL,
	[Price] [money] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Prices]  WITH CHECK ADD  CONSTRAINT [FK_ItemShop] FOREIGN KEY([ShopItemId])
REFERENCES [dbo].[ShopItems] ([Id])
GO

ALTER TABLE [dbo].[Prices] CHECK CONSTRAINT [FK_ItemShop]
GO

