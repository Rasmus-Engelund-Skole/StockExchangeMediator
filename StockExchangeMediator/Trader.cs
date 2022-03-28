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

        public Trader(Exchange exchange)
        {
            this.exchange = exchange;
        }

        public void buy(String stock, int quantity, Double price)
        {
            Order order = new Order();
            order.setStock(stock);
            order.setQuantity(quantity);
            order.setPrice(price);
            exchange.serve(order);
        }

    }
}
