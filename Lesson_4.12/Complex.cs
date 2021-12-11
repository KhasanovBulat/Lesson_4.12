using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._12
{
    class Complex
    {
        int real;
        int imaginary;

        public Complex()
        {

        }

        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + b.real * a.imaginary);
        }
        public override bool Equals(object obj)
        {
            Complex a = obj as Complex;
            if (a != null && a.real == real && a.imaginary == imaginary)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{real} + i{imaginary}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();

        }
    }
}
