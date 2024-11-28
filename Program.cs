﻿using System;

class Program
{
    static void bubbleSorT<T>(T[] array) where T : IComparable<T>
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++) 
        {
            for (int j = 0; j < n - i - 1; j++) 
            {
                if (array[j].CompareTo(array[j + 1]) > 0) 
                {
                    
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

   static void Main()
    {
        double[] numbers = { 5.2, 5.3, 5, 10, 10.1}; 

        Console.WriteLine("Przed:");
        Console.WriteLine(string.Join("  ", numbers));

        bubbleSorT(numbers);

        Console.WriteLine("Po sortowaniu:");
        Console.WriteLine(string.Join("  ", numbers));
    }
}