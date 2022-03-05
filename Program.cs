using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fraction = new Fraction(5, 2);
	    Console.WriteLine(fraction);
	    var f2 = new Fraction(fraction);
	    Console.WriteLine(f2.Ceil());
        }
    }
}

