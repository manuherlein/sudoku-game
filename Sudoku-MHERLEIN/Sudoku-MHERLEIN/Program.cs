using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_MHERLEIN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[9, 9];
            Random randNum = new Random();
            int filaLength = matrix.GetLength(0);
            int columnaLength = matrix.GetLength(1);


            for (int i = 0; i < 9; i++) ///////////// GENERA SIEMPRE LA MISMA MATRIZ PERO DE MANERA CORRECTA
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                }
            }

            //for (int i = 0; i < 9; ++i)    ////////// GENERA DISTINTOS VALORES PERO SE REPITEN
            //{
            //    for (int j = 0; j < 9; ++j)
            //    {
            //        matrix[i, j] = randNum.Next(1, 10);
            //    }
            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        for (int k = 0; k < 9; k++)
            //        {
            //            for (int l = 0; l < 9; l++)
            //            {
            //                if (matrix[i, k] > matrix[j, l])
            //                    {
            //                    int temp = matrix[i, k];
            //                    matrix[i, k] = matrix[j, l];
            //                    matrix[j, l] = temp;
            //                }
            //            }
            //        }
            //    }
            //}



            //for (int i = 0; i < 9; ++i) 
            //{
            //    for (int j = 0; j < 9; ++j)
            //    {
            //        if (randNum.Next(1, 10) != 0)
            //        {
            //            matrix[i, j] = randNum.Next(1, 10);
            //            int temp = matrix[i, j];
            //            matrix[i, i] = matrix[i, j];
            //            matrix[j, i] = temp;
            //        }
            //    }
            //}



            for (int i = 0; i < filaLength; i++)
            {
                for (int j = 0; j < columnaLength; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
