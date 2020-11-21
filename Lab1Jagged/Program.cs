using System;
using System.Linq;

namespace Lab1Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab work #1, task 1");
            Console.WriteLine("");
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[][] arr = new int[n][];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rnd.Next(2, 11)];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(10);
                }
            }
            int max = 0;
            Console.WriteLine("The created array:");
            PrintingTheArray(arr);
            SwapFirstAndMinElementsInEachRow(arr, n);
            Console.WriteLine("");
            Console.WriteLine("The updated array after swapping the first and minimum elements in each of the rows:");
            PrintingTheArray(arr);
            max = DetectIndexOfTheRowWithMaxFirstElement(arr, n, max);
            int[] arrmaxel = new int[arr[max].Length];
            arrmaxel = CopyingTheRow(arr, arrmaxel, max);

            static void SwapFirstAndMinElementsInEachRow(int[][] arr, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    int minm = arr[i][0];
                    int temp = arr[i][0];
                    int minIndexI = 0; int minIndexJ = 0;
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (arr[i][j] <= minm)
                        {
                            minm = arr[i][j];
                            minIndexI = i;
                            minIndexJ = j;
                        }
                    }
                    arr[i][0] = arr[minIndexI][minIndexJ];
                    arr[minIndexI][minIndexJ] = temp;
                }
            }
            static void PrintingTheArray(int[][] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                    }
                    Console.WriteLine();
                }
            }
            static int DetectIndexOfTheRowWithMaxFirstElement(int[][] arr, int n, int max)
            {
                max = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i][0] > arr[max][0]) max = i;
                }
                Console.WriteLine("");
                Console.WriteLine("Row #{0} has the largest first element", max + 1);
                return max;
            }
            Console.ReadKey();
            static int[] CopyingTheRow(int[][] arr, int[] arrmaxel, int max)
            {
                Console.WriteLine("");
                Console.WriteLine("Reversed row #{0}: ", max + 1);
                arrmaxel = arr[max];
                Array.Reverse(arrmaxel);
                for (int i = 0; i < arrmaxel.Length; i++)
                {
                    Console.Write(arrmaxel[i] + " ");
                }
                return arrmaxel;
            }
        }
    }
}
