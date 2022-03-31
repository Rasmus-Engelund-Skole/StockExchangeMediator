using StockExchangeMediator;

//Create exchange(mediator)
Exchange exchange = new Exchange();

//Create Financial Entities
FinancialEntity Børsen = new FinancialEntity("Børsen", exchange);

FinancialEntity LSE = new FinancialEntity("London Stock Exchange", exchange);

FinancialEntity WallStreet = new FinancialEntity("WallStreet", exchange);

//add financialenities to exchange(mediator)
exchange.AddFinancialEntity(Børsen);

exchange.AddFinancialEntity(LSE);

exchange.AddFinancialEntity(WallStreet);

//Create Regulator
Regulator regulator = new Regulator(exchange);

//add Regulator to exchange(mediator)
exchange.AddRegulator(regulator);


//Create Traders who knows the exchange(mediator)
Trader traderA = new Trader(exchange, "Poul");

Trader traderB = new Trader(exchange, "Elon Tåsk");

Trader traderC = new Trader(exchange, "Rasputin");


//Add traders to exchange(mediator)
exchange.AddTrader(traderA);

exchange.AddTrader(traderB);

exchange.AddTrader(traderC);

//Trade
traderA.buy("Novo", 2, 32.2d, "DK");

traderB.buy("Tesla", 1000, 1094.1d, "US");

traderB.buy("Kingfisher", 1000000, 1.2d, "UK");

traderC.buy("Alibaba", 10000, 70.2d, "CN");


