using System.Collections.Generic;

namespace Flyweight_pattern_example.Flyweight
{
    internal class CashMachineFactory
    {
        Dictionary<string, CashMachine> machines = new Dictionary<string, CashMachine>();
        public CashMachineFactory()
        {
            machines.Add("FruitCashMachine", new FruitCashMachine());
            machines.Add("SemiFinishedProductsCashMachine", new SemiFinishedProductsCashMachine());
        }

        public CashMachine GetCashMachine(string key)
        {
            if (machines.ContainsKey(key))
                return machines[key];
            else
                return null;
        }
    }
}
