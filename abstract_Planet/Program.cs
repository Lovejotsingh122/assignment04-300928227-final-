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
            GiantPlanet giantPlanet = new GiantPlanet("Mercury", 4879, 3.285, "GAS");
            GiantPlanet giantPlanet1 = new GiantPlanet("Jupitor", 139882, 317.8, "GAS");
            GiantPlanet giantPlanet3 = new GiantPlanet("Mars", 6779, 6.39, "GAS");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742, 5.9722, true);
            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            giantPlanet1.ToString();
            Program.WAITFORANYKEY();
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
        }
    }
}
