CREATE TABLE [stock].[Stock]
(
	[StockId] INT NOT NULL,
	[StockName] VARCHAR(256) NOT NULL,
	[YahooStockSymbol] VARCHAR(256) NULL,
	CONSTRAINT [PK_Stock] PRIMARY KEY ([StockId])
)
