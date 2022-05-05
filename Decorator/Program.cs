using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hardware_Components;

//A keyword to declare a set of related objects. Namespace is used to organise code and create globally unquie values.
namespace Hardware_Components
{
    //This clas "Program" is the main class which prints anything i did in the previous classes. Hardware and Additions and use there class names
    //To print the final product name and total cost.
    public class Program
    {
        static void Main(string[] args)
        {
            // (Method 1) 
            //Taking the constructor Hardware hardware. And telling it to print out the name, and the price of the hardware.
            //Nvidia Method
            Hardware hardware = new AMD();

            //Printing out the method in the console.
            Console.WriteLine(hardware.Description + " $" + hardware.Cost());


            // (Method 2) 
            //Taking are constructor hardware from Dying_Light class, and telling it to print the product name and the total price of the hardware.
            //Dying Light Method
            hardware = new Dying_Light(hardware);

            //Printing out the method in the console.
            Console.WriteLine(hardware.Description + " $" + hardware.Cost());
        }
    }
}
