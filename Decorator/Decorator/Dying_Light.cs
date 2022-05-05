using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Decorator.Components;
using Hardware_Components;

//A keyword to declare a set of related objects. Namespace is used to organise code and create globally unquie values.
namespace Hardware_Components
{
    //A public class with (custom name) that is connecetd to it's parent (Additions)
    public class Dying_Light : Additions
    {
        //We are calling a private constructor "Hardware" and basically saying _hardware is = hardware.
        //We are getting the name and cost from hardware, and including "Dying_Light to the list.
        //It will look like:
        //AMD CPU £800
        //AMD CPU, Dying Light $815.
        private readonly Hardware _hardware;

        public Dying_Light(Hardware hardware)
        {
            _hardware = hardware;
        }
        //Implement a method from Hardware.cs, which returns a string.
        //We changed the string type below to are class name as we are using this method for a different class and not in Hardware, instead Additions.
        public override string Description
        {
            get { return _hardware.Description + ", Dying Light"; }
        }
        //Took the constructor from Hardware.cs as it is a abstract class, and made it return Dying Light as £15.
        //I used Dying Light (hardware) to include Dying Light as a additional product to be added.
        public override double Cost()
        {
            return 15 + _hardware.Cost();
        }
    }
}




