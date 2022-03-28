using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Order
    {

        private String stock;
        private int quantity;
        private Double price;

        public String getStock()
        {
            return stock;
        }

        public void setStock(String stock)
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

        public Double getPrice()
        {
            return price;
        }

        public void setPrice(Double price)
        {
            this.price = price;
        }

    }
}
