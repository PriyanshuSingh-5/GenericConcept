using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    public class FindMaxNum
    {
        public static int FindMaxInteger(int firstnumb,int secondnumb,int thirdnumb)
        {
            if(firstnumb.CompareTo(secondnumb)>0 && firstnumb.CompareTo(thirdnumb)>0 )
            {
                return firstnumb;
            }
           else if (secondnumb.CompareTo(firstnumb) > 0 && secondnumb.CompareTo(thirdnumb) > 0)
            {
                return secondnumb;
            }
           else if (thirdnumb.CompareTo(firstnumb) > 0 && thirdnumb.CompareTo(secondnumb) > 0)
            {
                return thirdnumb;
            }
            else
            {
                Console.WriteLine("all 3 numbers are same");
                return 0;
            }
        }
    }
}
