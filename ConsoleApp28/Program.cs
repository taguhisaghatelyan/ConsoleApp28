using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Complex a = new Complex(3, 4);
            //Console.WriteLine(a);
            Complex a = new Complex(6, 7);
            Complex b = new Complex(4, 5);

            Console.WriteLine($"First Complex number` {a}");
            Console.WriteLine($"Second Complex number` {b}");
            Complex sum=Complex.Addition(a, b);
            Console.WriteLine($"Addition of {a} and {b} is` {sum}");
            Complex sub = Complex.Subtraction(a, b);
            Console.WriteLine($"Subtraction of {a} and {b} is` {sub}");
            Complex mult = Complex.Multiplication(a, b);
            Console.WriteLine($"Multiplication of {a} and {b} is` {mult}");
            Complex div = Complex.Division(a, b);
            Console.WriteLine($"Division of {a} and {b} is` {div}");
            double mag = Complex.Magnitude(a);
            Console.WriteLine($"Magnitude of {a}  is` {mag}");
            double phase = Complex.Phase(a);
            Console.WriteLine($"Phase of {a}  is` {phase}");

        }
    }
}
