using System;

namespace Exercise3
{
    class Solution
    {
        public int solution(int A, int B)
        {
            int count = 0;
            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j * j <= i; j++) 
                {
                    if (j * j == i)
                        count++;
                }
            }
            return count;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for B");
            int B = Convert.ToInt32(Console.ReadLine());
           
            Solution solu = new Solution();
            int display = solu.solution(A, B);
            Console.WriteLine(display);
           

        }
    }
}
