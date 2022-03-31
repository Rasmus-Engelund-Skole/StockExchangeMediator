using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class FinancialEntity
    {
        public string _name;

        //Reference to the mediator
        private readonly Exchange _exchange;

        public FinancialEntity(string name, Exchange exchange)
        {
            _name = name;
            _exchange = exchange;
        }
        
        //For simplicity the financial entity accepts all orders that has been validated
        public void Sell(Order order, string Tradername)
        {
            //Send confirmation back to trader
            _exchange.ConfirmTrade(order, Tradername, this);
        }

    }
}
