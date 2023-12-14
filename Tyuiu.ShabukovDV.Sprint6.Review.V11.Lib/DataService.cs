using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShabukovDV.Sprint6.Review.V11.Lib
{
    public class DataService
    {
        public int[,] GeneratingMatrix(int n, int m, int n1, int n2)
        {
            Random rnd = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    if ((i + 1) % 3 == 0)
                    {
                        array[i, j] = Convert.ToInt32(array[i - 1, j] * array[i - 2, j]);
                    }
                    else
                    {
                        int a = rnd.Next(n1, n2 + 1);
                        array[i, j] = a;
                    }
                }

            }
            return array;
        }

        public int resultGetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetUpperBound(0);
            int columns = array.GetUpperBound(1) + 1;
            int y = columns;
            int mult = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == c && (j >= k && j <= l) && (j % 2 == 0))
                    {
                        mult *= array[i, j];
                    }
                }
            }
            return mult;
        }
    }
}
