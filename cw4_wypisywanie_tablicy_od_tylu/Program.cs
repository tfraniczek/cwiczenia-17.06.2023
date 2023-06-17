using System;

class Program
{
    static void Main()
    {
        int[] array = generujtablice(10); // Generowanie tablicy o rozmiarze 10 z losowymi wartościami
        Console.WriteLine("Tablica od tyłu:");
        PokazOdwroconaTablice(array); // Wywołanie funkcji wypisującej zawartość tablicy od tyłu
        Console.ReadLine();
    }

    static int[] generujtablice(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100); // Generowanie losowej liczby z zakresu 0-99
        }
        return array;
    }

    static void PokazOdwroconaTablice(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}
