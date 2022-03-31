using StockExchangeMediator;

//This example is loosely based on and expands the example found on: https://dzone.com/articles/behavioural-design-patterns-mediator 


//Create exchange(mediator)
Exchange exchange = new Exchange();

//Create Traders who knows the exchange(mediator)
Trader traderA = new Trader(exchange, "Poul");

Trader traderB = new Trader(exchange, "Elon Tåsk");

Trader traderC = new Trader(exchange, "Rasputin");

//Create Financial Entities
FinancialEntity Børsen = new FinancialEntity("Børsen", exchange);

FinancialEntity LSE = new FinancialEntity("London Stock Exchange", exchange);

FinancialEntity WallStreet = new FinancialEntity("WallStreet", exchange);

//Create Regulator
Regulator regulator = new Regulator(exchange);

//Add traders to exchange(mediator)
exchange.AddTrader(traderA);

exchange.AddTrader(traderB);

exchange.AddTrader(traderC);

//add financialenities to exchange(mediator)
exchange.AddFinancialEntity(Børsen);

exchange.AddFinancialEntity(LSE);

exchange.AddFinancialEntity(WallStreet);


//add Regulator to exchange(mediator)
exchange.AddRegulator(regulator);


//Trade
traderA.Buy("Novo", 2, 32.2d, "DK");

traderB.Buy("Tesla", 1000, 1094.1d, "US");

traderB.Buy("Kingfisher", 1000000, 1.2d, "UK");

traderC.Buy("Alibaba", 10000, 70.2d, "CN");


