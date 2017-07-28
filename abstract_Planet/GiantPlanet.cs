using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*github link https://github.com/Lovejotsingh122/assignment04-300928227-final-
 * Name: Lovejot Singh
 * Date: 27-07-2017
 * Description: Ths is the GiantPlanet class which inherts from Planet class
 * */
namespace abstract_Planet
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // private instant variables
        private string _type;
        //public properties
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            return false;
        }
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //constructors
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }
    }
}

