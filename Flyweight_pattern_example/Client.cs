using Flyweight_pattern_example.Flyweight;
using Flyweight_pattern_example.ProductsEnum;
using System;
using System.Collections.Generic;

namespace Flyweight_pattern_example
{
    internal class Client
    {
        static void Main()
        {
            Random random = new Random();

            string Manufacturer1 = "FVCreaterCo.";
            string Manufacturer2 = "SFPCreaterCo.";

            CashMachineFactory cashMachineFactory = new CashMachineFactory();

            #region FruitCashMachines
                CashMachine FruitCashMachine1 = cashMachineFactory.GetCashMachine("FruitCashMachine");
                if (FruitCashMachine1 != null)
                    FruitCashMachine1.Create(new List<Product>() { Product.Apple, Product.Banana }, Manufacturer1, random.Next());

                CashMachine FruitCashMachine2 = cashMachineFactory.GetCashMachine("FruitCashMachine");
                if (FruitCashMachine2 != null)
                    FruitCashMachine2.Create(new List<Product>() { Product.Cabbage }, Manufacturer1, random.Next());
            #endregion

            #region SemiFinishedProductsCashMachines
                CashMachine SemiFinishedProductsCashMachine1 = cashMachineFactory.GetCashMachine("SemiFinishedCashMachine");
                if (SemiFinishedProductsCashMachine1 != null)
                    SemiFinishedProductsCashMachine1.Create(new List<Product>() { Product.Cutlet }, Manufacturer2, random.Next());

                CashMachine SemiFinishedProductsCashMachine2 = cashMachineFactory.GetCashMachine("SemiFinishedCashMachine");
                if(SemiFinishedProductsCashMachine2 != null)
                    SemiFinishedProductsCashMachine2.Create(new List<Product>() { Product.Mivina, Product.Dumplings }, Manufacturer2, random.Next());
            #endregion

            Console.Read();
        }
    }
}
