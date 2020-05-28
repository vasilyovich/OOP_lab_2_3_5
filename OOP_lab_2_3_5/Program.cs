using System;

namespace OOP_lab_2_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмiри матрицi: ");

            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[][] A = new int[int.Parse(elements[1])][];

            var random = new Random();

            Console.WriteLine("\n");

            for (int i = 0; i < A.Length; ++i)
            {
                A[i] = new int[int.Parse(elements[0])];

                for (int j = 0; j < A[i].Length; ++j)
                {
                    A[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    Console.Write("{0, -5}", A[i][j]);
                }

                Console.WriteLine("\n");
            }

            int min = A[0][0];

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (min >= A[i][j])
                    {
                        min = A[i][j];
                    }
                }
            }

            int max = A[0][0];

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (max <= A[i][j])
                    {
                        max = A[i][j];
                    }
                }
            }

            Console.WriteLine("Cереднє арифметичне максимального та мiнiмального елементiв матрицi: {0}", (min + max) / 2);
        }
    }
}
