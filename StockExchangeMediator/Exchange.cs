using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace StockExchangeMediator
{
    public class Exchange
    {

        private List<FinancialEntity> FinancialEntities;

        public Exchange()
        {  
            FinancialEntities = new List<FinancialEntity>();
        }

        public void AddFinancialEntity(FinancialEntity entity)
        {
            FinancialEntities.Add(entity);
        }

        public FinancialEntity FindEntity(string origin)
        {
            switch (origin)
            {
                case "DK":
                    foreach (FinancialEntity entity in FinancialEntities)
                    {
                        if ("Børsen" == entity._name)
                        {
                            return entity;
                        }
                    }
                    break;


                case "UK":
                    foreach (FinancialEntity entity in FinancialEntities)
                    {
                        if ("London Stock Exchange" == entity._name)
                        {
                            return entity;
                        }
                    }
                    break;

                case "US":
                    foreach (FinancialEntity entity in FinancialEntities)
                    {
                        if ("WallStreet" == entity._name)
                        {
                            return entity;
                        }
                    }
                    break;


                default:
                   return null;

            }
            return null;
        }

        public bool serve(Order order, string name)
        {
            /**
             * Choose the financial entity suitable for the order
             */
            var entity = FindEntity(order.StockOrigin);

            if (entity == null)
                return false;
            
            entity.sell(order);
            Console.WriteLine("From {0}({1})", entity._name, order.StockOrigin);
            Console.WriteLine("{3} bought {0} {1}, at {2} \n",
                                       order.getQuantity(),
                                       order.getStock(),
                                       order.getPrice(),
                                       name);
            return true;
                
            
        }

    }
}
