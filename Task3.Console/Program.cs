using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Solution.Observable;
using Task3.Solution.Observables;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            var bank = new Bank("bank1",stock);
            var broker = new Broker("broker petya",stock);
            stock.Register(broker);
            stock.Register(bank);

            stock.Market();

            System.Console.ReadLine();
        }
    }
}
