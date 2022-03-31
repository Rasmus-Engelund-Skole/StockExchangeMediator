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
        public void SetStockOrigin(string origin)
        {
           this.StockOrigin = origin;
        }

        public string? GetStockOrigin()
        {
            return this.StockOrigin;
        }

        public string? GetStock()
        {
            return stockName;
        }

        public void SetStock(string stock)
        {
            this.stockName = stock;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

    }
}
