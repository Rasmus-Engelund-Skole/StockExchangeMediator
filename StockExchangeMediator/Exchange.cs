using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace StockExchangeMediator
{
    public class Exchange
    {
        //List of financial entities
        private readonly List<FinancialEntity> FinancialEntities;

        //List of Traders
        private readonly List<Trader> Traders;

        //Regulator
        private Regulator? regulator;

        public Exchange()
        {
            FinancialEntities = new List<FinancialEntity>();
            Traders = new List<Trader>();

        }
        
        //Add reference to regulator
        public void AddRegulator(Regulator reg)
        {
            regulator = reg;    
        }

        //Add financial entity
        public void AddFinancialEntity(FinancialEntity entity)
        {

            FinancialEntities.Add(entity);
        }

        //Add trader to list
        public void AddTrader(Trader Trader)
        {

            Traders.Add(Trader);
        }

        //Find specific financial entity from the order origin.
        public FinancialEntity? FindEntity(string origin)
        {
            Console.WriteLine("Exchange finding financial entity\n");

            //Switch on the origin
            switch (origin)
            {
                //if stock origin is DK, find børsen
                case "DK":
                    foreach (FinancialEntity entity in FinancialEntities)
                    {
                        if ("Børsen" == entity._name)
                        {
                            return entity;
                        }
                    }
                    break;

                //if stock origin is UK, find London Stock Exchange
                case "UK":
                    foreach (FinancialEntity entity in FinancialEntities)
                    {
                        if ("London Stock Exchange" == entity._name)
                        {
                            return entity;
                        }
                    }
                    break;

                //if stock origin is US, find WallStreet
                case "US":
                    foreach (FinancialEntity entity in FinancialEntities)
                    {
                        if ("WallStreet" == entity._name)
                        {
                            return entity;
                        }
                    }
                    break;

                //return null if not found
                default:
                   return null;
                   

            }
            return null;
        }

        //Find specific trader for m name
        public Trader FindTrader(string Tradername)
        {
            Console.WriteLine("Exchange finding trader\n");

            //Find trader where name equals the name we are searching for and return it
            foreach (Trader T in Traders)
            {
                if(T.TraderName == Tradername)
                    return T;
            }

            return null;

        }

        //Sends the order from trader to correct financial entity
        public bool Serve(Order order, string Tradername)
        {
            /**
             * Choose the financial entity suitable for the order
             */
            //Find the entity from the origin
            var entity = FindEntity(order.StockOrigin);

            //if not found return false
            if (entity == null)
                return false;
            //Else Sell
            else
                entity.Sell(order, Tradername);
            //return true (tade went through)
            return true;
                
            
        }

        //Tell trader that his order went through
        public void ConfirmTrade(Order order, string Tradername, FinancialEntity entity)
        {
            //Find trader who ordered
            var trader = FindTrader(Tradername);

            //Confirm his order went through and from what entity he bought
            trader.OrderConfirmed(order, entity);
        }

        //Send traders order to validation in regulator
        public void Validate(Order order, string Tradername)
        {
            regulator.ValidateOrder(order, Tradername);
        }

        //Regulator has confirmed order is valid
        public void ValidationOk(Order order, string Tradername)
        {
            //Find trader from name
            var trader = FindTrader(Tradername);
            
            //Tell trader that order is valid
            trader.OrderValidated(order);

        }

        //Regulator has confirmed order is invalid
        public void ValidationNotOk(Order order, string Tradername)
        {
            //Find trader from name
            var trader = FindTrader(Tradername);

            //Tell trader that order is invalid
            trader.OrderNotValid(order);

        }
        
    }
}
