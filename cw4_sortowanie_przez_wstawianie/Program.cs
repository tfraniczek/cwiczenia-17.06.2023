using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class InsertionSort

{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int rOZMIAR, i;

        rOZMIAR = 10;
        int[] tab = new int[rOZMIAR];

        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            tab[i] = random.Next(100);
        }
        Console.WriteLine("Wygenerowana tablica: ");
        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            Console.WriteLine(tab[i]);
        }
        SortArray(tab);
        PrintArray(tab);
        Console.ReadLine();
    }

    private static void SortArray(int[] data)
    {
        for (int i = 1; i < data.Length; ++i)
        {
            int current = data[i];
            int j = i - 1;

            while (j >= 0 && data[j] > current)
            {
                data[j + 1] = data[j];
                j = j - 1;
            }

            data[j + 1] = current;
        }
    }

    private static void PrintArray(int[] data)
    {
        Console.Write("Posortowana tablica:\n");

        for (int i = 0; i < data.Length; ++i)
            Console.Write(data[i] + " ");

        Console.Write("\n");
    }
}
