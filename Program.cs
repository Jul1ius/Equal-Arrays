using System;

class Program
{
    static void Main()
    {
        int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool areIdentical = AreArraysIdentical(array1, array2);

        if (areIdentical)
        {
            Console.WriteLine("Arrays are identical.");
        }
        else
        {
            Console.WriteLine("Arrays are not identical.");
        }
    }

    static bool AreArraysIdentical(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }
}
