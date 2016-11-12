using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class PrimaryStudent : Student
    {
        static PrimaryStudent()
        {
            Console.WriteLine("Primary Student Static Constructor");
        }

        public PrimaryStudent()
        {
            Console.WriteLine("Primary Student Instance Constructor");
        }
    }
}
