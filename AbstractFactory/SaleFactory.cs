using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DesignPatterns.AbstractFactory
{
    // Factory es el Creator
    public abstract class SaleFactory
    {

        public abstract ISale GetSale(); 

    }

    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }

    }

    public class InternetSaleFactory : SaleFactory
    {

        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    // StoreSale es el ConcreteProduct
    public class StoreSale : ISale
    {

        private decimal _extra;

        public StoreSale(decimal extra)
        {

            _extra = extra;

        }

        public void sell(decimal total)
        {

            Console.WriteLine($"La venta en TIENDA tiene un total de {total + _extra}");

        }
    }

    public class InternetSale: ISale
    {

        private decimal _descuento;

        public InternetSale(decimal descuento)
        {
            _descuento = descuento;
        }

        public void sell(decimal total)
        {
            Console.WriteLine($"La venta en INTERNET tiene un total de {total - _descuento}");
        }
    }

    // ISale es el Product
    public interface ISale 
    {

        public void sell(decimal total);

    }



 
}
