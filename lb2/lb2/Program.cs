using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 5;
        int cols = 6;

        int[,] matrix = new int[rows, cols];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            int[] arr = new int[cols]; 
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(10);
                Console.Write("{0} ", matrix[i, j]);
                arr[j] = matrix[i, j];
            }
            Array.Sort(arr);
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0} ", arr[j]); 
            }
            Console.WriteLine();
        }

        int zeroRowsCount = 0;
        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (hasZero)
            {
                zeroRowsCount++;
            }
        }
        Console.WriteLine("Number of rows with zero element: {0}", zeroRowsCount);

        int maxEqualCount = 0;
        int maxEqualColIndex = 0;
        for (int j = 0; j < cols; j++)
        {
            int equalCount = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i, j] == matrix[i + 1, j])
                {
                    equalCount++;
                }
            }
            if (equalCount > maxEqualCount)
            {
                maxEqualCount = equalCount;
                maxEqualColIndex = j;
            }
        }
        Console.WriteLine("Number of the column with the largest number of identical elements: {0}", maxEqualColIndex);
    }
}