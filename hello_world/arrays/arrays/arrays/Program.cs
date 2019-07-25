using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum p1 = new Sum(2,2);
            p1.setPolymom();
            Console.WriteLine(p1.getPolynom());
            Console.WriteLine(p1.getSum());
        }

    }


    class Polynom
    {
        public readonly int Pow;

        protected int[] indexes;

        public Polynom(int pow)
        {
            this.Pow = pow;
        }
        public Polynom() 
        {
            this.Pow = 2;
        }

        public void setPolymom()
        {
            this.indexes = new int[this.Pow + 1];
            for (int index = 0; index <= this.Pow; index++)
            {
                Console.Write($"x^[{index}] = ");
                this.indexes[index] = Polynom.writeInt();
                Console.WriteLine("");
            }
        }

        static int writeInt()
        {
            string str;
            int number;
            try
            {
                str = Console.ReadLine();
                number = int.Parse(str);
            }
            catch
            {
                number = 10;
            }
            return number;
        }

        public string getPolynom()
        {
            string strPolynom = "";
            for (int index = this.Pow; index >= 0; index--)
            {
                if (this.indexes[index] == 0) continue;
                else if (index < 0) strPolynom += $"- x*{this.indexes[index]}*x^{index} ";
                else if (index != this.Pow) strPolynom += $"+ {this.indexes[index]}*x^{index} ";
                else strPolynom += $"{this.indexes[index]}*x^{index} ";
            }
            if (strPolynom == "") strPolynom = "0";
            return strPolynom + " = 0";
        }
    }

    class Sum : Polynom
    {
        protected readonly int value;

        public Sum() : base()
        {
            this.value = 1;
        }

        public Sum(int pow) : base(pow)
        {
            this.value = 1;
        }

        public Sum(int pow, int value) : base(pow)
        {
            this.value = value;
        }

       public int getSum()
       {
            double sum = 0;
            for (int index = 0; index <= this.Pow; index++)
            {
                sum += this.indexes[index] * Math.Pow(value, index);
            }

            return (int)sum;
       }

    }
}
