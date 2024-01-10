using AbstractFactory_DesignPatterns.AbstractFactory;
using System;

namespace AbstractFactory_DesignPatterns
{

    class Program
    {

        static void Main(string[] args)
        {

            SaleFactory storeSaleFactory = new StoreSaleFactory(10);

            SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.sell(15);

            ISale sale2 =  internetSaleFactory.GetSale();
            sale2.sell(15);
            
        }

    }

}
