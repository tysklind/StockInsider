CREATE TABLE [portfolio].[PortfolioStock]
(
	[PortfolioId] INT NOT NULL,
	[StockId] INT NOT NULL, 
	CONSTRAINT PK_PortfolioStock PRIMARY KEY ([PortfolioId], [StockId]),
    CONSTRAINT [FK_PortfolioStock_Stock] FOREIGN KEY ([StockId]) REFERENCES [stock].[Stock]([StockId]), 
    CONSTRAINT [FK_PortfolioStock_Portfolio] FOREIGN KEY ([PortfolioId]) REFERENCES [portfolio].[Portfolio]([PortfolioId])
)
