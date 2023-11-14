using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.IvanchikovDA.Sprint4.V9.Reviev.Lib
{
    public class DataService
    {
        public int Calculate(int rows, int columns, string value)
        {
            int[,] mtrx = new int[rows, columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(index, 1));
                    index++;
                }

            }

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
