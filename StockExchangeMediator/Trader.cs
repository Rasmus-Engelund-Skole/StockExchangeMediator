using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Trader
    {

        private Exchange exchange;
        private string _name;

        public Trader(Exchange exchange, string name)
        {
            this.exchange = exchange;
            this._name = name;
        }

        public void buy(string stock, int quantity, double price, string origin)
        {
            Order order = new Order();
            order.setStock(stock);
            order.setQuantity(quantity);
            order.setPrice(price);
            order.setStockOrigin(origin);
            var result = exchange.serve(order, _name);

            if (!result)
            {
                Console.WriteLine("!!!!!!!!!!ERROR!!!!!!!!!!");
                Console.WriteLine("{0}, error in your transaction, unknown stock origin.", _name);
                Console.WriteLine("Acceptable origins: DK, UK, US. \n");
            }
            
        }

    }
}
