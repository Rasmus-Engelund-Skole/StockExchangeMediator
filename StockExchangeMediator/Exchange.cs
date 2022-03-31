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

        private List<Trader> Traders;

        private Regulator? regulator;
        public Exchange()
        {
            FinancialEntities = new List<FinancialEntity>();
            Traders = new List<Trader>();

        }
        
        public void AddRegulator(Regulator reg)
        {
            regulator = reg;    
        }

        public void AddFinancialEntity(FinancialEntity entity)
        {

            FinancialEntities.Add(entity);
        }

        public void AddTrader(Trader Trader)
        {
            

            Traders.Add(Trader);
        }

        public FinancialEntity? FindEntity(string origin)
        {
            Console.WriteLine("Exchange finding financial entity\n");

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

        public Trader FindTrader(string Tradername)
        {
            Console.WriteLine("Exchange finding trader\n");

            foreach (Trader T in Traders)
            {
                if(T._name == Tradername)
                    return T;
            }

            return null;

        }

        public bool serve(Order order, string Tradername)
        {
            /**
             * Choose the financial entity suitable for the order
             */
            var entity = FindEntity(order.StockOrigin);

            if (entity == null)
                return false;
            
            entity.sell(order, Tradername);
         
            return true;
                
            
        }

        public void ConfirmTrade(Order order, string Tradername, FinancialEntity entity)
        {
            var trader = FindTrader(Tradername);
         
            trader.OrderConfirmed(order, Tradername, entity);
        }


        public void ValidationOk(Order order, string Tradername)
        {
            var trader = FindTrader(Tradername);

            trader.OrderValidated(order);

        }

        public void ValidationNotOk(Order order, string Tradername)
        {
            var trader = FindTrader(Tradername);

            trader.OrderNotValid(order);

        }

        public void Validate(Order order, string Tradername)
        {
            regulator.ValidateOrder(order, Tradername);
        }
    }
}
