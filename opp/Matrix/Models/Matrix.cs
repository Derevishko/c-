using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix.Models
{
    class DoubleMatrix
    {
        private int demensionI;
        private int demensionJ;

        private Vector[] body;

        public int[] demension {
            get
            {
                return new int[2] { this.demensionI, this.demensionJ };
            }
        }

        public DoubleMatrix(int i, int j)
        {
            this.demensionI = i > 0 ? i : 1;
            this.demensionJ = j > 0 ? j : 1;
            Vector[] body = new Vector[j];
            for (int index = 0; index < j; index++)
            {
                body[index] = new Vector(i);
            }
            this.body = body;
        }

        public override string ToString()
        {
            string matrix = "{";
            for (int index = 0; index < this.demensionJ; index++)
            {
                matrix += "\n\t";
                matrix += this.body[index].ToString();
            }
            matrix += "\n}";
            return matrix;
        }

        public DoubleMatrix T()
        {

            return new DoubleMatrix(1, 1);
        } 

    }
}
