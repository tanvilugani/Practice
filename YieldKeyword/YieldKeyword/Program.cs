using System;

namespace YieldKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);                
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Yield keyword is used when a function, operator or accessor is an iterator. 
        /// It returns value for each element and retains the state of the function.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        public static System.Collections.Generic.IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
