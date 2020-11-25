using System;
using System.Linq;

namespace Count_by_X
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountByX(1,10);
            //CountByX(2, 5);
            //countbyLambda(1,10);
            //countBy(2, 5);
            //countBy(3, 9);
        }

        public static int CountByX (int a, int b){

            int c = 0;
            for (int i = 0; i < b; i++)
            {
                c += a;

                Console.WriteLine(c);
            }
            return 0;
        }

        public static int[] countBy(int x, int n)
        {
            int[] z = new int[n];
            for (int i = 0; i < n; i++)
            {
                z[i]= (i + 1) * x;
                Console.WriteLine(z[i]);
            }
            return z;
        }

        public static int[] countbyLambda(int f, int j) 
        {
            return Enumerable.Range(1, j).Select(i => i * f).ToArray();
        }
    }

}   
