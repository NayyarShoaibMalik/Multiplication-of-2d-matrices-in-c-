
using System;

namespace ppp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ , ] arr1=new int [20,20];
            int[ , ] arr2 = new int[20,20];
            
            int r1,r2,c1,c2,i,j;
            Console.Write("Enter the row-size  : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the coloumn-size  : ");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the row-size  : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the coloumn-size  : ");
            c2 = Convert.ToInt32(Console.ReadLine());



            if (c1 != r2)
            {
                Console.WriteLine("Matrix multiplication not possible");
            }




            else
            {


                int[,] mult = new int[r1,c2];


            // array 1
            Console.WriteLine("Enter the elements of array1 ");
            for( i = 0; i< r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                
            }



            // Array 2
            Console.WriteLine("Enter the elements of array2 ");
            for (i = 0; i < r2; i++)
            {
                 for (j = 0; j < c2; j++)
                 {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
            }


            // multiplication 
            for (i = 0; i < r1; i++)
            {
               for (j = 0; j < c2; j++)
               {
                        mult[i, j] = 0;
                   for (int k = 0; k < c1; k++)
                   {
                      mult[i, j] += arr1[i, j] * arr2[i, j];
                   }
               }
            }

            // Output 
            Console.WriteLine("product  of arrays is : ");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write(mult[i,j] + "\t");
                    if (j == c1 - 1)
                    {
                        Console.WriteLine();
                    }

                }
            }


            }


        }
    }
}
