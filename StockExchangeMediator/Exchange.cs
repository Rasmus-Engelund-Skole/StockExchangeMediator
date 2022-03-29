using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace StockExchangeMediator
{
    public class Exchange
    {

        private List<FinancialEntity> financialEntities;

        public Exchange(FinancialEntity financialEntity)
        {
            financialEntities.Add(financialEntity);
        }

        public void serve(Order order)
        {
            // IKKE KORREKT
            var financialEntity = new FinancialEntity();
            /**
             * Choose the financial entity suitable for the order
             */
            financialEntity.sell(order);
        }

    }
}
