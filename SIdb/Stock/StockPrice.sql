CREATE TABLE [stock].[StockPrice]
(
	[StockId] INT NOT NULL,
	[DateId] INT NOT NULL,
	[ClosingPrice] MONEY NULL,
	CONSTRAINT [PK_PortfolioStock] PRIMARY KEY ([StockId], [DateId]), 
    CONSTRAINT [FK_StockPrice_Stock] FOREIGN KEY ([StockId]) REFERENCES [stock].[Stock]([StockId])
)
