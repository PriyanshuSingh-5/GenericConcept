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
            int[] intArray = { 112, 344, 432, 555, 678 };
            Generic<int> generic = new Generic<int>(intArray);
            generic.PrintMaxValue();

        }
    }
}
