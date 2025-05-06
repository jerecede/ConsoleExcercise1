using System;
using System.IO;
using System.Text.RegularExpressions;
using ConsoleExcercise1;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //        int number = 42;
        //        float pi = 3.14f;
        //        double e = 2.71828; //si usa spesso questo
        //        decimal price = 19.99m; //questo per numeri piu precisi, soldi per esempio

        //        string name = "Jeremias"; //stringa non interpolata
        //        string greeting = $"Hello, {name}!"; //stringa interpolata
        //        string verbatim = @"a verbatim string"; //stringa verbatim, non prende accapo, scrive /n
        //        string multiline = @"This is a
        //multiline string";

        //        char initial = 'J'; //molto legato al suo numero di riferimento
        //        bool isTrue = true;

        //        var isActiveVar = false; //var implicitly typed variable
        //        var numberVar = 10;
        //        var piVar = 3.14f;

        //        if (true)
        //        {

        //        }
        //        else if (false)
        //        {

        //        }
        //        else
        //        {

        //        }

        //        for (int i = 0; i < 10; i++)
        //        {

        //        }

        //        foreach (var item in new[] { 1, 2, 3 }) //new come var
        //        {
        //            Console.WriteLine(item);
        //        }

        //        while (true)
        //        {
        //            break;
        //        }

        //        do
        //        {
        //            break;
        //        }
        //        while (true);

        //        switch (number)
        //        {
        //            case 1:
        //                Console.WriteLine("Switch One");
        //                break;
        //            case 2:
        //                Console.WriteLine("Switch Two");
        //                break;
        //            default:
        //                Console.WriteLine("Switch Default");
        //                break;
        //        }

        //PrintHello();
        //var testPrint = new TestPrint();
        //testPrint.PrintHola();//funzione no static
        //TestPrint.PrintCiao();//funzione static

        //Exercise1();
        //Exercise2();

        //for (int i = 0; i < args.Length; i++)
        //{
        //    Console.WriteLine(args[i]);
        //}

        //Exercise3(args[1], args[0]);
    }
    private static void PrintHello()
    {
        Console.WriteLine("hello");
    }

    // print tutti i numeri da 1 a 100, se divisibile per 7, print pippo,
    // se invece quadrato perfetto, print pluto,
    // se entrambi, print paperone
    public static void Exercise1()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 7 == 0 && CheckPerfectSquare(i))
            {
                Console.WriteLine(i + " paperone");
            }
            else if (i % 7 == 0)
            {
                Console.WriteLine(i + " pippo");
            }
            else if (CheckPerfectSquare(i))
            {
                Console.WriteLine(i + " pluto");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static bool CheckPerfectSquare(int number)
    {
        double result = Math.Sqrt(number);
        return result % 1 == 0;
    }

    //guess number, tra 1 e 10, utente deve indovinare e riprova finche non indovina,
    //poi feauture quando sbagla dire se piu altro o piu basso
    public static void Exercise2()
    {
        int numberToGuess = new Random().Next(1, 11);

        bool isInt;
        int number;

        Console.WriteLine("Ciao, indovina il mio numero! è compreso tra 1 e 10");

        do //invece di do while potevo fare un while(true) con l'uso di continue e break
        {
            Console.WriteLine("\nINSERISCI");
            string input = Console.ReadLine();//devo prevenire il null

            //invece di tryparse potevo usare try e catch
            isInt = int.TryParse(input, out number); //se è false, number diventa 0

            if (isInt) //oppure number == 0
            {
                if (numberToGuess > number)
                {
                    Console.WriteLine("il numero da indovinare è piu alto");
                }
                else
                {
                    Console.WriteLine("il numero da indovinare è piu basso");
                }
            }
            else
            {
                Console.WriteLine("inserisci un numero intero, bastardo");
            }
        }
        while (numberToGuess != number);

        Console.WriteLine("\nBravo hai indovinato! era il numero " + numberToGuess);
    }

    //quante volte appara wrd in str, mi sono complicato la vita non funziona
    //public static int Exercise3(string wrd, string str)
    //{
    //    int count = 0;
    //    string pattern = $"\\{wrd}\\";
    //    Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
    //    Match mtch = rgx.Match(str);
    //    if (mtch.Success)
    //    {
    //        count = mtch.Groups.Count;
    //        Console.WriteLine(mtch.Groups.Count);
    //    }
    //    return count;
    //}
}