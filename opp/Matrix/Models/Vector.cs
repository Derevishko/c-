using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix.Models
{
    class Vector
    {
        public readonly int demension;
        private double[] _body;

        public double[] body {get { return this._body; } }

        public double length
        {
            get
            {
                 double length = 0;
                  for ( int index = 0; index < this.demension; index++ )
                  {
                      length += this._body[index] * this._body[index];
                  }
                return Math.Sqrt(length);
            }
        }

        public Vector(double[] body)
        {
            this.demension = body.Length;
            this._body = body;
        }

        public Vector(int demension)
        {
            this.demension = demension > 0 ? demension : 1;
            this.fill();
        }

        public void fill()
        {
            double[] arr = new double[this.demension];
            for (int index = 0; index < this.demension; index++)
            {   
                arr[index] = this.input(index);
            }
            this._body = arr;
        }  
        
        private double input(int index)
        {
            double number = default;
            try
            {
                Console.WriteLine($"Введите x[{index + 1}]");
                number = Double.Parse(Console.ReadLine());
            } catch(ArgumentNullException)   
            {
                Console.WriteLine("Введено не число");
            } catch (FormatException)
            {
                Console.WriteLine("Введено не корректное число");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка");
            }
            return number;
        }

        public override string ToString()
        {
            string vector = "{";
            for (int index = 0; index < this.demension; index++)
            {
                if (index != 0)
                {
                    vector += ", ";
                }
                vector += this._body[index];
            }
            vector += "}";
            return vector;
        }

        public static Vector operator + (Vector v1, Vector v2)
        {
            if (v1.demension != v2.demension) throw new Exception("demension1 != demension2");
            double[] arr = v1.body;
            for (int index = 0; index < v1.demension; index++)
            {
                arr[index] += v2.body[index];
            }

            return new Vector(arr);
        }
    }
}
