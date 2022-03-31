using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Regulator
    {
        private Exchange exchange;

        public Regulator(Exchange exchange)
        {
            this.exchange = exchange;
        }

        public void ValidateOrder(Order order, string Tradername)
        {
            Console.WriteLine("Regulator validating order\n");

            if(order == null)
                exchange.ValidationNotOk(order, Tradername);

            if(order.getPrice() > 0 & 
                order.getQuantity() > 0 & 
                order.getStock != null & 
                order.getStockOrigin != null)
                exchange.ValidationOk(order, Tradername);
            else
                exchange.ValidationNotOk(order, Tradername);
        }

    }
}
