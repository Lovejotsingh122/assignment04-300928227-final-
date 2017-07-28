using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Lovejot Singh
 * Date: July 27, 2017
 * Description: This is the sub-class TerrestrialPlanet of class Planet
 */
namespace abstract_Planet
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _oxygen;
        // PUBLIC PROPERTIES
        public bool HasMoons()
        {
            bool moons = false;

            if (MoonCount > 0)
            {
                moons = true;
            }

            return moons;
        }
        public bool Habitable()
        {
            if (this._oxygen == true)
            {
                return true;
            }
            return false;
        }
        // CONSTRUCTORS
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }

    }
}
