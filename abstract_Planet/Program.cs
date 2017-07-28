using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * github link https://github.com/Lovejotsingh122/assignment04-300928227-final-
 * Name: Lovejot Singh
 * Date: 28 july 2017
 * description: this is the main program where we can check test harness
 */
namespace abstract_Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************** Planets Description ***********************************");
            Console.WriteLine("******************************** © Lovejot Singh-300928227 ********************************");
            Console.WriteLine();
            GiantPlanet giantPlanet = new GiantPlanet("Mercury", 4879, 3.285, "GAS");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742, 5.9722, true);
            GiantPlanet giantPlanet1 = new GiantPlanet("Venus", 12104, 4.867, "GAS");
            GiantPlanet giantPlanet2 = new GiantPlanet("Mars", 6779, 6.39, "GAS");
            GiantPlanet giantPlanet3 = new GiantPlanet("Jupiter", 139822, 317.8, "GAS");
            GiantPlanet giantPlanet4 = new GiantPlanet("Saturn",116464, 5.683, "GAS");
            GiantPlanet giantPlanet5 = new GiantPlanet("Uranus",50724, 8.681, "GAS");
            GiantPlanet giantPlanet6 = new GiantPlanet("Neptune", 49244, 1.024, "GAS");
            GiantPlanet giantPlanet7 = new GiantPlanet("Pluto", 23266,1.30, "GAS");
            Console.WriteLine("Press any Key to See the Planet's Information");
            Program.PRESSANYKEY();
            giantPlanet.ToString();
            Program.PRESSANYKEY();

            giantPlanet1.ToString();
            Program.PRESSANYKEY();

            terrestrialPlanet.ToString();
            Program.PRESSANYKEY();

            giantPlanet2.ToString();
            Program.PRESSANYKEY();

            giantPlanet3.ToString();
            Program.PRESSANYKEY();

            giantPlanet4.ToString();
            Program.PRESSANYKEY();

            giantPlanet5.ToString();
            Program.PRESSANYKEY();

            giantPlanet6.ToString();
            Program.PRESSANYKEY();

            giantPlanet7.ToString();
            Program.PRESSANYKEY();

            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("****************************************** The End ****************************************");

            Program.PRESSANYKEY();
            
        }
        static void PRESSANYKEY()
        {
            Console.ReadLine();
        }
    }
}
