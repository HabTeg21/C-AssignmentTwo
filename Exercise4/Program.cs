using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        class Spiral
        {
            public void spiral(int a, int b, int[,] matrix)
            {
                int i, k = 0, l = 0;
                while (k < a && l < b)
                {
                    for (i = l; i < b; ++i)
                    {
                        Console.Write(matrix[k, i] + " ");
                    }
                    k++;
                    for (i = k; i < a; ++i)
                    {
                        Console.Write(matrix[i, b - 1] + " ");
                    }
                    b--;
                    if (k < a)
                    {
                        for (i = b - 1; i >= l; --i)
                        {
                            Console.Write(matrix[a - 1, i] + " ");
                        }
                        a--;
                    }
                    if (l < b)
                    {
                        for (i = a - 1; i >= k; --i)
                        {
                            Console.Write(matrix[i, l] + " ");
                        }
                        l++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Spiral s = new Spiral();
            int a = 3, b = 3;
            int[,] matrix = { {1,2,3 },
                            {4,5,6 },
                            { 7,8,9} };
        
            s.spiral(a, b, matrix);
          
        }
    }
}
