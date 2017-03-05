using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedNOptionalParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code for Named Params
            #region
            // The method can be called in the normal way, by using positional arguments.
            Console.WriteLine(CalculateBMI(123, 64));

            // Named arguments can be supplied for the parameters in either order.
            Console.WriteLine(CalculateBMI(weight: 123, height: 64));
            Console.WriteLine(CalculateBMI(height: 64, weight: 123));

            // Positional arguments cannot follow named arguments.
            // The following statement causes a compiler error.
            //Console.WriteLine(CalculateBMI(weight: 123, 64));

            // Named arguments can follow positional arguments.
            Console.WriteLine(CalculateBMI(123, height: 64));

            #endregion

            //Code for Optional Params
            #region

            // Instance anExample does not send an argument for the constructor's
            // optional parameter.
            ExampleClass anExample = new ExampleClass();
            anExample.ExampleMethod(1, "One", 1);
            anExample.ExampleMethod(2, "Two");
            anExample.ExampleMethod(3);

            // Instance anotherExample sends an argument for the constructor's
            // optional parameter.
            ExampleClass anotherExample = new ExampleClass("Provided name");
            anotherExample.ExampleMethod(1, "One", 1);
            anotherExample.ExampleMethod(2, "Two");
            anotherExample.ExampleMethod(3);

            // The following statements produce compiler errors.

            // An argument must be supplied for the first parameter, and it
            // must be an integer.
            //anExample.ExampleMethod("One", 1);
            //anExample.ExampleMethod();

            // You cannot leave a gap in the provided arguments. 
            //anExample.ExampleMethod(3, ,4);
            //anExample.ExampleMethod(3, 4);

            // You can use a named parameter to make the previous 
            // statement work.
            anExample.ExampleMethod(3, optionalint: 4);

            #endregion
        }

        static int CalculateBMI(int weight, int height)
        {
            return (weight * 703) / (height * height);
        }
    }

    class ExampleClass
    {
        private string _name;

        // Because the parameter for the constructor, name, has a default
        // value assigned to it, it is optional.
        public ExampleClass(string name = "Default name")
        {
            _name = name;
        }

        //This is not possible if following function is declared.
        //public void ExampleMethod(int required, string optionalstr,
        //    int optionalint)
        //{
        //    Console.WriteLine("Inside function 1", _name, required, optionalstr,
        //        optionalint);
        //}

        // The first parameter, required, has no default value assigned
        // to it. Therefore, it is not optional. Both optionalstr and 
        // optionalint have default values assigned to them. They are optional.
        public void ExampleMethod(int required, string optionalstr = "default string",
            int optionalint = 10)
        {
            Console.WriteLine("{0}: {1}, {2}, and {3}.", _name, required, optionalstr,
                optionalint);
        }
    }
}
