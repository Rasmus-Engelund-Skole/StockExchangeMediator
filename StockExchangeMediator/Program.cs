using StockExchangeMediator;

//Create mediator
Exchange exchange = new Exchange();

//Create Financial Entities
FinancialEntity Børsen = new FinancialEntity("Børsen");

FinancialEntity LSE = new FinancialEntity("London Stock Exchange");

FinancialEntity WallStreet = new FinancialEntity("WallStreet");

//
exchange.AddFinancialEntity(Børsen);

exchange.AddFinancialEntity(LSE);

exchange.AddFinancialEntity(WallStreet);

//Create Traders who knows the exchange(mediator)
Trader traderA = new Trader(exchange, "Poul");

Trader traderB = new Trader(exchange, "Elon Tåsk");

Trader traderC = new Trader(exchange, "Rasputin");


//Trade
traderA.buy("Novo", 2, 32.2d, "DK");

traderB.buy("Tesla", 1000, 1094.1d, "US");

traderB.buy("Kingfisher", 1000000, 1.2d, "UK");

traderC.buy("Alibaba", 10000, 70.2d, "CN");


