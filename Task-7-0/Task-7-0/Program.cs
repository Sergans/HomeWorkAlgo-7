using System;

namespace Task_7_0
{
    class Program
    {
        static int TotalP(int from,int to)
        {
            if (from == to)
            {
                return 1;
            }
            if (from > to)
            {
                return 0;
            }
            return TotalP(from + 1, to) + TotalP(from * 2, to);
        }
        static int Chess(int a,int b)
        {
            if (a == 0&&b>0)
            {
                return 1;
            }
           else if (a > 0 && b == 0)
            {
                return 1;
            }
            else if (a == 0&&b==0)
            {
                return 0;
            }
            
            return Chess(a, b-1) + Chess(a-1, b);
        }
        static void Print2(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(a[i, j]);
                Console.Write("\r\n");
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            int m = 5;
            Console.WriteLine(Chess(25, 91));
            int[,] a = new int[5, 5];
            
            int i, j;
            for (j = 0; j < m; j++)
                a[0, j] = 1; // Первая строка заполнена единицами
            for (i = 1; i < n; i++)
            {
                a[i, 0] = 1;
                for (j = 1; j < m; j++)
                    a[i, j] = a[i, j - 1] + a[i - 1, j];
            }


            Print2(n, m,a);
            //var total = TotalP(1, 2);
            //Console.WriteLine(total);
        }
    }
}
