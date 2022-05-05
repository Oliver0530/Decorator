using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hardware_Components;

//A keyword to declare a set of related objects. Namespace is used to organise code and create globally unquie values.
namespace Hardware_Components
{
    // A public abstract class which other classes can share/use.
    public abstract class Hardware
    {
        // Virtual string can be overriden. Example, i can use "Description" to assign a new veriable or text in my components folder
        public virtual string Description { get; protected set; } = "Hardware CPU's";

        // A public abstract named Cost to represent the total value of a product.
        public abstract double Cost();
    }
}
