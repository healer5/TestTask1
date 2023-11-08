using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Task1
        Console.WriteLine("Hello world!");

        //Task2
        while (true)
        {
            Console.Clear();
            bool isSleeping = AskIfBearIsSleeping();
            if (isSleeping)
                DrawBearWithClosedEyes();
            else
                DrawBearWithOpenEyes();

            Thread.Sleep(1000);
        }
    }

    static bool AskIfBearIsSleeping()
    {
        Console.Write("Is the bear sleeping? Press 'y' if he is (any other key for open eyes): ");
        char input = Console.ReadKey().KeyChar;
        return (input == 'y' || input == 'Y');
    }

    static void DrawBearWithOpenEyes()
    {
        Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
        Console.WriteLine("────█░░█░░░░░█░░█────");
        Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
        Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
    }

    static void DrawBearWithClosedEyes()
    {
        Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
        Console.WriteLine("────█░░-░░░░░-░░█────");
        Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
        Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        Console.WriteLine("    -   -       -   -    ");
    }
}
