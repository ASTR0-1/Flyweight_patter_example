using Flyweight_pattern_example.ProductsEnum;
using System.Collections.Generic;

namespace Flyweight_pattern_example.Flyweight
{
    abstract class CashMachine
    {
        protected string CashMachineType;
        protected string Manufacturer;
        protected int Id;
        protected List<Product> Products;

        public abstract void Create(List<Product> Products, string Manufacturer, int Id);

        public abstract void AddProduct(Product product);
        public abstract void SaveCheck();
        public abstract void PrintCheck();
    }
}
