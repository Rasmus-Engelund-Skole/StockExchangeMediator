using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Regulator
    {
        //Reference to the mediator
        private readonly Exchange exchange;

        public Regulator(Exchange exchange)
        {
            this.exchange = exchange;
        }

        /*Validates that the price and quantity is positive, 
        and that the stockname and origin is not null
        */
        public void ValidateOrder(Order order, string Tradername)
        {
            Console.WriteLine("Regulator validating order\n");

            if(order == null)
                exchange.ValidationNotOk(order, Tradername);

            if(order.GetPrice() > 0 & 
                order.GetQuantity() > 0 & 
                order.GetStock != null & 
                order.GetStockOrigin != null)
                exchange.ValidationOk(order, Tradername);
            else
                exchange.ValidationNotOk(order, Tradername);
        }
        
    }
}
