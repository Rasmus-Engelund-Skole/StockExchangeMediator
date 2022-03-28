using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeMediator
{
    public class Exchange
    {

        private list<FinancialEntity> financialEntities;

        public Exchange(FinancialEntity financialEntity)
        {
            this.financialEntities.add(financialEntity);
        }

        public void serve(Order order)
        {

            /**
             * Choose the financial entity suitable for the order
             */
            financialEntity.sell(order);
        }

    }
}
