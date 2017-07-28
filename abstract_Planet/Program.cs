﻿using System;
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
            Console.WriteLine("************************************ Planet Description ***********************************");
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
            giantPlanet.ToString();
            giantPlanet1.ToString();
            terrestrialPlanet.ToString();
            giantPlanet2.ToString();
            giantPlanet3.ToString();
            giantPlanet4.ToString();
            giantPlanet5.ToString();
            giantPlanet6.ToString();
            giantPlanet7.ToString();
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************");
            Console.WriteLine("****************************************** The End ****************************************");

            Program.WAITFORANYKEY();
            
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
        }
    }
}
