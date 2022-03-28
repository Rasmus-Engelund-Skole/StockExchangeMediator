namespace StockExchangeMediator
{

    public void Main(string[] args)
    {

        FinancialEntity FinancialEntity = new FinancialEntity();

        Exchange exchange = new Exchange(FinancialEntity);

        Trader trader = new Trader(exchange);

        trader.buy("stock_a", 2, 32.2d);
    }
}