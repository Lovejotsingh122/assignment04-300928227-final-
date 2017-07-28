using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Name: Lovejot Singh
 Date: 27-07-2017
 Description: this is an interface that gives detail about habitable property which must implemented in any class that subscribe it.*/

namespace abstract_Planet
{
    public interface IHabitable
    {
        //public property
        bool Habitable();
    }
}
