using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class FinancialEntity
    {
        public string _name;

        private Exchange _exchange;

        public FinancialEntity(string name, Exchange exchange)
        {
            _name = name;
            _exchange = exchange;
        }
        
        public bool sell(Order order)
        {

            return true;
        }

    }
}
