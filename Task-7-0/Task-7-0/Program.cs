using System;

namespace Task_7_0
{
    public class TestCase
    {
       public int a { get; set; }
       public int b { get; set; }
       public int count { get; set; }
      
    }
    class Program
    {
        static void TestCount(TestCase testCase)
        {
            int[,] mas = new int[testCase.a, testCase.b];
            if (testCase.count == Chess1(testCase.a, testCase.b) && testCase.count == Chess(mas.GetLength(0)-1, mas.GetLength(1)-1))
            {
                Console.WriteLine("VALID TEST");
            }
            else 
            {
                Console.WriteLine("INVALID TEST");
            }
           

        }
        static int Chess(int index_a,int index_b)
        {
            if (index_a == 0&&index_b>0)
            {
                return 1;
            }
           else if (index_a > 0 && index_b == 0)
            {
                return 1;
            }
            else if (index_a == 0&&index_b==0)
            {
                return 0;
            }
            
            return Chess(index_a, index_b-1) + Chess(index_a-1, index_b);
        }
        static int Chess1(int n,int m)
        {
            int[,] a = new int[n, m];
            int i, j;
            for (j = 0; j < m; j++)
                a[0, j] = 1; 
            for (i = 1; i < n; i++)
            {
                a[i, 0] = 1;
                for (j = 1; j < m; j++)
                    a[i, j] = a[i, j - 1] + a[i - 1, j];
            }
            return a[i - 1, j - 1];

        }
        
        static void Main(string[] args)
        {
            
            TestCase testCase = new TestCase { a = 6, b = 6,count=252 };
            TestCase testCase1 = new TestCase { a = 1, b = 2, count = 1 };
            TestCase testCase2 = new TestCase { a = 2, b = 1, count = 1 };
            
            TestCount(testCase);
            TestCount(testCase1);
            TestCount(testCase2);
            

        }
    }
}
