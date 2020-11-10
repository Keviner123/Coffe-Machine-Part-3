using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            //We create a new coffemachine 
            CoffeeMachine MyCoffeeMachine = new CoffeeMachine();

            //We fill both compartments up
            MyCoffeeMachine.Water.Fill();
            MyCoffeeMachine.Department.Fill(new EspressoPowder());

            //We brew the coffee and check the status
            Console.WriteLine(MyCoffeeMachine.Brew(1));
            Console.WriteLine(MyCoffeeMachine.CoffeeCupsAvailable.Count);

            Console.ReadKey();

        }
    }
}
