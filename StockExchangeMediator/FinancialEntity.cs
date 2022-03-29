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

        

        public FinancialEntity(string name)
        {
            _name = name;
        }
        
        public bool sell(Order order)
        {

            return true;
        }

    }
}
