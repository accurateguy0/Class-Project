using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] A = new int[2, 3];
            int[,] B = new int[2, 3];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                A[i,j ] = rnd.Next(1, 100);
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    B[i, j] = rnd.Next(1, 100);
            int[,] C = new int[2, 3];
            for(int i = 0;i < A.GetLength(0); i++)
                for(int j = 0;j < A.GetLength(1); j++)
                    C[i,j] = A[i,j] + B[i,j];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", C[i, j]);

                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }

    }
}
