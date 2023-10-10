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
        protected string exercise = "2.4. В двухмерном массиве вещественных " +
            "чисел поменять местами строки и столбцы " +
            "с одинаковыми номерами.";

        public Part_2_4(int _cols, int _rows)
        {
            this.cols = _cols;
            this.rows = _rows;
            this.matrix = new int[this.cols, this.rows];
        }

        public override void Do()
        {
            FillArray();

            PrintArray("Элементы массива: ");

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

            PrintArray("Элементы после работы программы: ");
        }

        private void FillArray()
        {
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    matrix[i, j] = i;
        }

        private void PrintArray(string _phrase)
        {
            Console.WriteLine(_phrase);

            char copyleft = '\u1000';

            Console.WriteLine(copyleft);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
