using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Order
    {

        private string? stock;
        private int quantity;
        private double price;
        public string? StockOrigin;


        public Order()
        {

        }

        public Order(string Stock, int Quantity, double Price, string Origin)
        {
            this.stock = Stock;
            this.quantity = Quantity;
            this.price = Price;
            this.StockOrigin = Origin;
        }


        public string? getStock()
        {
            return stock;
        }

        public void setStock(string stock)
        {
            this.stock = stock;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

    }
}
