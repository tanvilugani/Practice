using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Student
    {
        static Student()
        {
            Console.WriteLine("Student Static Constructor");
        }

        public Student()
        {
            Console.WriteLine("Student Instance Constructor");
        }

        public static int StudentCount = 5;
    }
}
