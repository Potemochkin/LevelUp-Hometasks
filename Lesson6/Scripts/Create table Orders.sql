USE [MyShop]
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 16.03.2023 21:18:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Orders](
	[Id] [uniqueidentifier] NOT NULL,
	[ClientId] [uniqueidentifier] NOT NULL,
	[OrderStatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Client] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Client]
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_OrderStatuses] FOREIGN KEY([OrderStatus])
REFERENCES [dbo].[OrderStatuses] ([Value])
GO

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_OrderStatuses]
GO

