using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CSharpAdvanceConcepts
{
    static class ExtensionMethodsCSharp
    {
        //Extension Method
        //1- If you want to create a extension method then that method must be static method.
        //2 - Extension method parameter must be passed with 'this' keyword along with the type we want to extend.
        //3- Class must be static class when you create extension method.

        public static int Div(this CalculatorClass cal, int first, int second)
        {
            return first / second;
        }
        //public static int WordCount(this String str)
        //{
        //    int count = 0;
        //    return count;
        //}
        static void Main()
        {
            var calc = new CalculatorClass();
            Console.WriteLine( calc.Add(2, 5));
            Console.WriteLine(calc.Sub(5, 2));
            Console.WriteLine(calc.Mul(2, 8));
            Console.WriteLine(calc.Div(8, 2));
            string str = "this is my class of .NET ";
            //str.WordCount();

        }
    }

    class ExtendingString
    {

    }
}
