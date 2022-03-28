namespace StockExchangeMediator
{

    public static void Main(String[] args)
    {

        var FinancialEntity financialEntity;
        FinancialEntity = new FinancialEntity();

        var Exchange exchange = new Exchange(financialEntity);

        Trader trader = new Trader(exchange);

        trader.buy("stock_a", 2, 32.2d);
    }
}