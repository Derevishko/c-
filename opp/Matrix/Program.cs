using System;
using Matrix.Models;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoubleMatrix m1 = new DoubleMatrix(2,3);
            // Console.WriteLine(m1);
            Vector v1 = new Vector(new double[] { 1, 2, 3 });
            Vector v2 = new Vector(new double[] { 1, 2, 3 });
            Vector v3 = v1 + v2;
            Console.WriteLine(v3);
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
