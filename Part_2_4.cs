using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_1
{
    internal class Part_2_4 : Part
    {
        int cols;
        int rows;
        int[,] matrix;

        public Part_2_4(int _cols, int _rows)
        {
            this.cols = _cols;
            this.rows = _rows;
            this.matrix = new int[this.cols, this.rows];
        }

        public override void Do()
        {
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    matrix[i, j] = rand.Next(10);

            Console.WriteLine("Элементы массива: ");

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{matrix[i, j]}  ");
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < cols; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    int temp = matrix[j, i];
                    matrix[j, i] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }

            Console.WriteLine("Элементы после работы программы: ");

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{matrix[i, j]}  ");
                Console.WriteLine();
            }
        }
    }
}
