using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        /// <summary>
        /// Static constructor is invoked either when the first instance of the class is created or when a static member is called.
        /// Case1,2 and 3 may be interchanged to understand the impact.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Case 1 : To check the order of calling of the constructors.
            var primaryStudent = new PrimaryStudent();

            Console.WriteLine("------------------------------");

            //Case 2 : To illustrate that the static constructor is called only once and if already called not called again.
            var student1 = new Student();
            var student2 = new Student();

            Console.WriteLine("------------------------------");

            //Case 3 : Static member calling
            int studentCount = Student.StudentCount;

            Console.ReadKey();
        }
    }
}
