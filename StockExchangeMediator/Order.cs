using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Order
    {

        //Atrributes from order we want to use
        private string? stockName;
        private int quantity;
        private double price;
        public string? StockOrigin;


        public Order()
        {

        }

        public Order(string Stock, int Quantity, double Price, string Origin)
        {
            this.stockName = Stock;
            this.quantity = Quantity;
            this.price = Price;
            this.StockOrigin = Origin;
        }

        //Set and get for all attributes
        public void setStockOrigin(string origin)
        {
            this.StockOrigin = origin;
        }

        public string? getStockOrigin()
        {
            return this.StockOrigin;
        }

        public string? getStock()
        {
            return stockName;
        }

        public void setStock(string stock)
        {
            this.stockName = stock;
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
