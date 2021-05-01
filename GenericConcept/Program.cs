using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
   public  class Program
    {
        static void Main(string[] args)
        {
            //Integer array
            int[] intArray = { 112, 344, 432, 555, 678 };
            Generic<int> generic = new Generic<int>(intArray);
            generic.PrintMaxValue();

            //Double array
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            Generic<double> genericDouble = new Generic<double>(doubleArray);
            genericDouble.PrintMaxValue();

        }
    }
}
