using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Trader
    {
        //Reference to the mediator
        private Exchange exchange;
        public string _name { get; set; }

        public Trader(Exchange exchange, string name)
        {
            this.exchange = exchange;
            this._name = name;
        }

        //Buy function, takes parameters and creates order
        public void buy(string stock, int quantity, double price, string origin)
        {
            Order order = new Order();
            order.setStock(stock);
            order.setQuantity(quantity);
            order.setPrice(price);
            order.setStockOrigin(origin);

            Console.WriteLine("{0} wants to buy {1} {2} {3} {4}", _name, order.getQuantity(),
                                       order.getStock(),
                                       order.getPrice(),
                                       order.getStockOrigin());

            //Calls validate through the exchange
            exchange.Validate(order, _name);


        }

        //Writes the order to console when confirmed from financial entity
        public void OrderConfirmed(Order order, FinancialEntity entity)
        {
            Console.WriteLine("From {0}({1})", entity._name, order.StockOrigin);
            Console.WriteLine("{3} bought {0} {1}, at {2} \n",
                                       order.getQuantity(),
                                       order.getStock(),
                                       order.getPrice(),
                                       _name);

        }

        //Writes to console when order is valid(with regulator), and the buys through exchange
        public void OrderValidated(Order order)
        {
            Console.WriteLine("Order has been validated, now buying \n");

            //Buy through exchange
            var result = exchange.serve(order, _name);

            if (!result)
            {
                Console.WriteLine("!!!!!!!!!!ERROR!!!!!!!!!!");
                Console.WriteLine("{0}, error in your transaction, unknown stockName origin.", _name);
                Console.WriteLine("Acceptable origins: DK, UK, US. \n");
            }
        }
        //Writes to console when order is invalid (checked with regulator)
        public void OrderNotValid(Order order)
        {
            Console.WriteLine("You order of {0}, {1}, {2}, {3} is not valid",
                order.getStock(),
                order.getPrice(),
                order.getQuantity(), 
                order.getStockOrigin());

        }

    }
}