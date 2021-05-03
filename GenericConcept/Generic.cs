using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    public class Generic<T>  ///Generic class
    {

      public T[] value;
    public Generic(T[] value)
    {
        this.value = value;
    }

    public T[] Sort(T[] values) //sort 
    {
        Array.Sort(values);
        return values;
    }
    void add(params int[] a)  //param parameter
    {

    }
    public T MaxValue(params T[] values) //sorting maximum values
    {
        var sorted_values = Sort(values);

        return sorted_values[sorted_values.Length - 1];
    }

    public T MaxMethod()
    {
        var max = MaxValue(this.value);
        return max;
    }

    public void PrintMaxValue()   //To print max values
    {
        var max = MaxValue(this.value);
        Console.WriteLine("Maximum value is " + max);
    }
}
}
