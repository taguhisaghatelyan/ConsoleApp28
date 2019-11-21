using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Complex
    {
        public double Real { get; set; }
        public double Im { get; set; }
        public Complex()
        {

        }
        public Complex (double real, double im)
        {
            Real = real;
            Im = im;
        }
        public override string ToString()
        {
            return $"{Real}+{Im}i";
        }

        public static Complex Addition(Complex a,Complex b)
        {
            Complex sum = new Complex();
            sum.Real= a.Real + b.Real;
            sum.Im = a.Im + b.Im;
            return sum;
        }
        public static Complex Subtraction(Complex a,Complex b)
        {
            Complex sub = new Complex();
            sub.Real = a.Real - b.Real;
            sub.Im = a.Im - b.Im;
            return sub;
        }
        public static Complex Multiplication(Complex a,Complex b)
        {
            Complex mult = new Complex();
            mult.Real = (a.Real * b.Real)-(a.Im*b.Im);
            mult.Im = (a.Real * b.Im)+(a.Im*b.Real);
            return mult;
        }
        public static Complex Division(Complex a, Complex b)
        {
            Complex div = new Complex();
            div.Real = ((a.Real * b.Real) + (a.Im * b.Im))/(Math.Pow(b.Real,2)+Math.Pow(b.Im,2));
            div.Im = ((a.Real * b.Im) - (a.Im * b.Real))/ (Math.Pow(b.Real, 2) + Math.Pow(b.Im, 2));
            return div;
        }
        public static double Magnitude(Complex a)
        {
            double mag = Math.Sqrt(Math.Pow(a.Real, 2) + Math.Pow(a.Im, 2));

            return mag;
        }
        public static double Phase(Complex a)
        {

            double phase=2*Math.Atan((Math.Sqrt(a.Real*a.Real+a.Im*a.Im)-a.Real)/a.Im);
            return phase;
        }
    }
}
