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
        private readonly Exchange exchange;
        public string TraderName { get; set; }

        public Trader(Exchange exchange, string name)
        {
            this.exchange = exchange;
            this.TraderName = name;
        }

        //Buy function, takes parameters and creates order
        public void Buy(string stock, int quantity, double price, string origin)
        {
            Order order = new Order();
            order.SetStock(stock);
            order.SetQuantity(quantity);
            order.SetPrice(price);
            order.SetStockOrigin(origin);

            Console.WriteLine("{0} wants to Buy {1} {2} {3} {4}", TraderName, order.GetQuantity(),
                                       order.GetStock(),
                                       order.GetPrice(),
                                       order.GetStockOrigin());

            //Calls validate through the exchange
            exchange.Validate(order, TraderName);


        }

        //Writes the order to console when confirmed from financial entity
        public void OrderConfirmed(Order order, FinancialEntity entity)
        {
            Console.WriteLine("From {0}({1})", entity._name, order.StockOrigin);
            Console.WriteLine("{3} bought {0} {1}, at {2} \n",
                                       order.GetQuantity(),
                                       order.GetStock(),
                                       order.GetPrice(),
                                       TraderName);

        }

        //Writes to console when order is valid(with regulator), and the buys through exchange
        public void OrderValidated(Order order)
        {
            Console.WriteLine("Order has been validated, now buying \n");

            //Buy through exchange
            var result = exchange.Serve(order, TraderName);

            if (!result)
            {
                Console.WriteLine("!!!!!!!!!!ERROR!!!!!!!!!!");
                Console.WriteLine("{0}, error in your transaction, unknown stockName origin.", TraderName);
                Console.WriteLine("Acceptable origins: DK, UK, US. \n");
            }
        }
        //Writes to console when order is invalid (checked with regulator)
        public void OrderNotValid(Order order)
        {
            Console.WriteLine("{4}, Your order of {0}, {1}, {2}, {3} is not valid",
                order.GetStock(),
                order.GetPrice(),
                order.GetQuantity(), 
                order.GetStockOrigin(),
                TraderName);

        }

    }
}