using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hardware_Components;

//A keyword to declare a set of related objects. Namespace is used to organise code and create globally unquie values.
namespace Hardware_Components
    {
    //A public abstract class which other classes can share/use.
    public abstract class Additions : Hardware
    { 
        //A abstract override string allows a method to override a virtual or abstract method from its base class.
        //This case are virtual method is located in Hardware.cs
        public abstract override string Description { get; }
    }
}
