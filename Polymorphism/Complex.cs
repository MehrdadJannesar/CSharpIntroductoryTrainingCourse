namespace Polymorphism
{
    public class Complex
    {
        private double real;
        private double imaginary;

        public Complex(double r, double i)
        {
            real = r;
            imaginary = i;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }

        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
}
