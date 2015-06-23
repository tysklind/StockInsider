CREATE TABLE [portfolio].[Portfolio]
(
	[PortfolioId] INT NOT NULL,
	[PortfolioName] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
	CONSTRAINT [PK_Stock] PRIMARY KEY ([PortfolioId]),
    CONSTRAINT [FK_Portfolio_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [customer].[Customer]([CustomerId])
)
