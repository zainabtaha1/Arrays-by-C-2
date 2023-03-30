
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Dimensional_Array
{ // Multi-Dimensional Array == Regular array
    internal class Program
    {
        static void Main(string[] args)
        { // Two Dimensional Array
            int[,] degrees = new int[2,3]{ {89,92,83} , {64,93,81} };
            degrees[0,2]=88;
            int i, j;
            for (  i = 0; i < 2; i++)
            {
                for ( j = 0; j < 3; j++)
                    Console.WriteLine(degrees[i, j]);
            }
            //Summation of 'Two Dimensional Array'
            int[,] A = new int[2,3];
            int[,] B = new int[2, 3];
            int[,] C = new int[2, 3];
            int x, y;
            for ( x = 0; x < 2; x++)
            {
                for ( y = 0; y < 3; y++)
                {
                    Console.WriteLine("A[" + x +"," + y + "]is");
                    A[x,y] = int.Parse(Console.ReadLine());
                    Console.WriteLine("B[" + x + "," + y + "]is");
                    B[x, y] = int.Parse(Console.ReadLine());
                }
            }
            for (x = 0; x < 2; x++)
            {
                for (y = 0; y < 3; y++)
                {
                    C[x, y] = A[x, y] + B[x, y];
                    Console.WriteLine("C[" + x + "," + y + "]is" + C[x,y]+"\t");
                }
                Console.WriteLine();
            }
        }

    }
}
