using System;
using System.Reflection.Emit;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int rOZMIAR, i, z, n;

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
        int max;
        int min;
        int MaxIMin = tab.Length;
        max = tab[0];
        min = tab[0];
        foreach (int ii in tab)
        {
            if (ii > max)
            {
                max = ii;
            }
            if (ii < min)
            {
                min = ii;
            }
        }

        Console.WriteLine("Największa Liczba z tabeli:" + max);
        Console.WriteLine("Największa Liczba z tabeli:" + min);

        Console.ReadLine();
    }
    
}
