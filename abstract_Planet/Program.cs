using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************ Planet Description ***********************************");
            GiantPlanet giantPlanet = new GiantPlanet("Mars", 6779, 6.39, "GAS");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742, 5.9722, true);
            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            Program.WAITFORANYKEY();
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
        }
    }
}
