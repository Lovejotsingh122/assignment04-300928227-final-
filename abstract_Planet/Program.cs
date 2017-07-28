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
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742, 5.9722, true);
            GiantPlanet giantPlanet1 = new GiantPlanet("Venus", 12104, 4.867, "GAS");
            GiantPlanet giantPlanet2 = new GiantPlanet("Mars", 6779, 6.39, "GAS");
            giantPlanet.ToString();
            giantPlanet1.ToString();
            terrestrialPlanet.ToString();
            giantPlanet2.ToString();
            Program.WAITFORANYKEY();
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
        }
    }
}
