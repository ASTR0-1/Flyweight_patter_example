using Flyweight_pattern_example.ProductsEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern_example.Flyweight
{
    internal class SemiFinishedProductsCashMachine : CashMachine
    {
        public SemiFinishedProductsCashMachine()
        {
            CashMachineType = "SemiFinishedProductsCashMachine";
        }

        public override void AddProduct(Product product)
        {
            Products.Append(product);
        }

        public override void Create(List<Product> Products, string Manufacturer, int Id)
        {
            if (Products is null)
            {
                this.Products = Products;
                this.Manufacturer = Manufacturer;
                this.Id = Id;
            }
            else
                throw new Exception("CashMachine allready created.");
        }

        public override void PrintCheck()
        {
            Console.WriteLine("Printing check...Check is printed.");
        }

        public override void SaveCheck()
        {
            Console.WriteLine("Saving check...Check is saved.");
        }
    }
}
