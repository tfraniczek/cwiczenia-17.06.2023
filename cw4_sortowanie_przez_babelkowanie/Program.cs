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
        BubbleSort(tab);
        PrintArray(tab);
        Console.ReadLine();
    }

    static void BubbleSort(int[] data)
    {
        int n = data.Length;

        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (data[j] > data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
    }
       static void PrintArray(int[] data)
        {
            Console.Write("Posortowana tablica:\n");

            for (int i = 0; i < data.Length; ++i)
                Console.Write(data[i] + " ");

            Console.Write("\n");
        }
    }
