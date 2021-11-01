using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr = CreateArr(4);
            Print(arr);
            Print(GetDiagonalEl(arr));
            Print(Getmax(arr));


        }


        /// <summary>
        /// Creates Two dementional array
        /// </summary>
        /// <param name="n">Takes one parameter wich shows array size</param>
        /// <returns>Returns two dementional array by given size</returns>
        public static int[,] CreateArr(int n)
        {
            Random rnd = new Random();
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(1, 10);
                }

            }
            return arr;
        }

        /// <summary>
        /// Finding Max from two dementionnal array
        /// </summary>
        /// <param name="arr">Takes two dementional array as param</param>
        /// <returns>Returns max from two dementional array</returns>
        public static int Getmax(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }
            return max;
        }

        /// <summary>
        /// Getting diagonal elements from given array
        /// </summary>
        /// <param name="arr">Takes two dementional aray as param</param>
        /// <returns>Returns diagonal elements as array</returns>
        public static int[] GetDiagonalEl(int[,] arr)
        {
            int[] diagonalElements = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                diagonalElements[i] = arr[i, i];
            }
            return diagonalElements;
        }

        /// <summary>
        /// Prints two dementional arrays
        /// </summary>
        /// <param name="arr">Take as parameter two dementional arrays</param>
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// Prints array in console
        /// </summary>
        /// <param name="arr">Takes array as param</param>
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        /// <summary>
        /// Prints integer values to console
        /// </summary>
        /// <param name="value">Takes int values as parameter</param>
        public static void Print(int value)
        {
            Console.WriteLine(value);

        }
    }
}