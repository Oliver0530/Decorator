using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hardware_Components;

//A keyword to declare a set of related objects. Namespace is used to organise code and create globally unquie values.
namespace Hardware_Components
{
    // A public class named Intel and connected to the inhereted class Hrdware.cs
    public class Intel : Hardware
    {
        //Public class with description of hardware component type.
        public Intel()
        {
            Description = "Nvidia Grace CPU";
        }
        //Inhereted from the base class Hardware.cs.
        //Public override is a method declaration called override base method. It contains the same signature "Cost"
        //And returns the total Cost of the virtual string "AMD CPU in the terminal
        public override double Cost()
        {
            return 600;
        }
    }
}
