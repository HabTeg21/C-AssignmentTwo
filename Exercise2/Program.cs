using System;

namespace Exercise2
{
    class Solution
    {
        // int arraySize;
        //int i = 0;
        //int[] array;
        //public void GetData()
        //{
        //    Console.WriteLine("Enter the size of the array");
        //    arraySize = Convert.ToInt32(Console.ReadLine());
        //    array = new int[arraySize];
        //    try
        //    {
        //     while (i < arraySize)
        //        {
        //            Console.WriteLine("Enter the number");
        //            array[i] = Convert.ToInt32(Console.ReadLine());
        //            i++;
        //        }
        //    }catch(Exception e)
        //    {

        //    }
            
        //}

        public int GetSolution(int[] A)
        {
            int temp = 0, count = 1, tempCount;
            int mostOften = A[0];
            for (int i = 0; i < (A.Length - 1); i++)
            {
                temp = A[i];
                tempCount = 0;
                for (int j = 1; j < A.Length; j++)
                {
                    if (temp == A[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    mostOften = temp;
                    count = tempCount;
                }
            }
            return mostOften;
        }
      
    }
    class Program
    {      
        static void Main(string[] args)
        {

            int arraySize;
            int i = 0;
            int[] array;
            Console.WriteLine("Enter the size of the array");
            arraySize = Convert.ToInt32(Console.ReadLine());
            array = new int[arraySize];
            try
            {
                while (i < arraySize)
                {
                    Console.WriteLine("Enter the number");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
            }
            catch (Exception e)
            {

            }

            Solution solution = new Solution();
           
           // solution.GetData();
            solution.GetSolution(array);
            Console.WriteLine();
            Console.WriteLine(solution.GetSolution(array));
           
        }
    }
}
