using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.genric_nongenricassignment
{
    internal class assign4jagged
    {
        //4.WAP to create jagged array, initialized data & display the details
        static void Main(string[] args)
        {
            int[][] arr2 = new int[2][];
            {
                arr2[0] = new int[] { 1, 2, 3, 4, 5};
                arr2[1] = new int[] { 2, 3, 7, 5 };




                for (int row = 0; row < arr2.Length; row++)
                {
                    for (int col = 0; col < arr2[row].Length; col++)
                    {
                        Console.Write(arr2[row][col] + " ");
                    }
                    Console.WriteLine("\n");
                }

            }



        }
    }
}
