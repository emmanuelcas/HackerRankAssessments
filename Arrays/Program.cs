using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //DosDArrrayDS();
            //ArraysLeftRotation();
            //NewYearChaos();
            MinimunSwaps2();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void DosDArrrayDS()
        {
            //------------------------------------ PROBLEMA -------------------------------------
            //Given 6x6 2D Array, :

            //1 1 1 0 0 0
            //0 1 0 0 0 0
            //1 1 1 0 0 0
            //0 0 0 0 0 0
            //0 0 0 0 0 0
            //0 0 0 0 0 0
            //An hourglass in  is a subset of values with indices falling in this pattern in 's graphical representation:

            //a b c
            //  d
            //e f g
            //There are  hourglasses in . An hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum. The array will always be .

            //Example
            //-9 -9 -9  1 1 1 
            // 0 -9  0  4 3 2
            //-9 -9 -9  1 2 3
            // 0  0  8  6 6 0
            // 0  0  0 -2 0 0
            // 0  0  1  2 4 0

            //The  hourglass sums are:
            //-63, -34, -9, 12, 
            //-10,   0, 28, 23, 
            //-27, -11, -2, 10, 
            //  9,  17, 25, 18
            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            List<List<int>> arr = new List<List<int>>();
            arr.Add(new List<int> { -9, -9, -9, 1, 1, 1 });
            arr.Add(new List<int> { 0, -9, 0, 4, 3, 2 });
            arr.Add(new List<int> { -9, -9, -9, 1, 2, 3 });
            arr.Add(new List<int> { 0, 0, 8, 6, 6, 0 });
            arr.Add(new List<int> { 0, 0, 0, -2, 0, 0 });
            arr.Add(new List<int> { 0, 0, 1, 2, 4, 0 });

            //------------------------------ PREPARACION DEL INPUT ------------------------------


            //------------------------------------ SOLUCION -------------------------------------
            var HourglassSums = new List<int>();
            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 4; row++)
                {
                    int sum = 0;
                    for (int k = 0; k < 3; k++)
                        sum = sum + arr[row][col + k];
                    sum = sum + arr[row + 1][col + 1];
                    for (int k = 0; k < 3; k++)
                        sum = sum + arr[row + 2][col + k];
                    HourglassSums.Add(sum);
                }
            }
            int max = HourglassSums[0];
            foreach (int sum in HourglassSums)
            {
                if (sum > max)
                    max = sum;
            }

            Console.WriteLine(max);
            //return HourglassSums.Sort[1];
            //------------------------------------ SOLUCION -------------------------------------
        }


        static void ArraysLeftRotation()
        {
            //------------------------------------ PROBLEMA -------------------------------------
            //A left rotation operation on an array shifts each of the array's elements 1 unit to the left.
            //For example, if 2 left rotations are performed on array [1, 2, 3, 4, 5], then the array would
            //become [3, 4, 5, 1, 2]. 
            //Note that the lowest index item moves to the highest index in a rotation. This is called a circular array.

            //rotLeft has the following parameter(s):
            //int a[n]: the array to rotate
            //int d: the number of rotations
            //Returns
            //int a'[n]: the rotated array

            //Sample Input
            //5 4
            //1 2 3 4 5

            //Sample Output
            //5 1 2 3 4
            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            var a = new List<int>{ 1, 2, 3, 4, 5};
            int d = 2; //cantidad de rotaciones

            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------
            for (int i = 0; i < d; i++)
            {
                a.Add(a[0]);
                a.RemoveAt(0);
            }
                


            Console.WriteLine(a.ToString());
            //return HourglassSums.Sort[1];
            //------------------------------------ SOLUCION -------------------------------------
        }


        static void NewYearChaos()
        {
            //------------------------------------ PROBLEMA -------------------------------------
            //A left rotation operation on an array shifts each of the array's elements 1 unit to the left.
            //For example, if 2 left rotations are performed on array [1, 2, 3, 4, 5], then the array would
            //become [3, 4, 5, 1, 2]. 
            //Note that the lowest index item moves to the highest index in a rotation. This is called a circular array.

            //rotLeft has the following parameter(s):
            //int a[n]: the array to rotate
            //int d: the number of rotations
            //Returns
            //int a'[n]: the rotated array

            //Sample Input
            //5 4
            //1 2 3 4 5

            //Sample Output
            //5 1 2 3 4


            //OTRO EJ 1 2 5 3 7 8 6 4 DEBERIA DAR 7

            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            var q = new List<int> { 1,2,5,3,7,8,6,4 };

            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------
            bool toochaotic=false;
            int i = 0;
            int total = 0;
            int cant = q.Count();

            foreach (int num in q)
            {
                if (q[i] > i + 3)
                    toochaotic = true;
                i = i + 1;
            }

            i = 0;
            foreach (int num in q)
            {

                int empcontrolar = 0;
                if (q[i] - 2 > 0)
                    empcontrolar = q[i] - 2;

                for (int j = empcontrolar; j < i; j++)
                {
                    if (q[j] > q[i])
                        total++;
                }
                i = i + 1;
            }


            if (toochaotic == true)
                Console.WriteLine("Too chaotic");
            else
                Console.WriteLine(total);
            //------------------------------------ SOLUCION -------------------------------------
        }


        static void MinimunSwaps2()
        {
            //------------------------------------ PROBLEMA -------------------------------------
            //Calculate and return minmun amount of swaps to order the array
            //Perform the following steps:

            //i   arr                         swap (indices)
            //0   [7, 1, 3, 2, 4, 5, 6]   swap (0,3)
            //1   [2, 1, 3, 7, 4, 5, 6]   swap (0,1)
            //2   [1, 2, 3, 7, 4, 5, 6]   swap (3,4)
            //3   [1, 2, 3, 4, 7, 5, 6]   swap (4,5)
            //4   [1, 2, 3, 4, 5, 7, 6]   swap (5,6)
            //5   [1, 2, 3, 4, 5, 6, 7]
            //It took 5 swaps to sort the array.

            //------------------------------------ PROBLEMA -------------------------------------

            //------------------------------ PREPARACION DEL INPUT ------------------------------
            var arr = new List<int> {7,1,3,2,4,5,6 };

            //------------------------------ PREPARACION DEL INPUT ------------------------------

            //------------------------------------ SOLUCION -------------------------------------

            int total = 0;
            var dic = new Dictionary<int, int>();

            int j = 0;
            foreach (int num in arr)
            {
                dic.Add(num,j);
                j++;
            }

            for (int i=0; i<arr.Count(); i++)
            {
                if (arr[i] != i + 1)
                {
                    int CurrentValue = arr[i];
                    int PosRightValue = dic[i + 1];

                    dic[CurrentValue] = PosRightValue;
                    arr[PosRightValue] = CurrentValue;
                    dic[i + 1] = i;
                    arr[i] = i + 1;
                    total++;
                }
            }


            Console.WriteLine(total);
            //------------------------------------ SOLUCION -------------------------------------
        }

    }
}
