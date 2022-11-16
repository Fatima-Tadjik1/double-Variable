using System;


public class Program
{
    public static void Main()
    {
        double Fliesskommazahl = 42.2;
        int Ganzzahl = 50;
        double Ergebnis1;
        double Ergebnis2;
        double Ergebnis3;

        string Muell1 = "150";
        string Muell2 = "150.5";

        Ergebnis1 = Fliesskommazahl * Fliesskommazahl;
        Ergebnis2 = Ergebnis1 + Ganzzahl;

        Console.WriteLine(Ergebnis1);
        Console.WriteLine(Ergebnis2);

        Ergebnis3 = Convert.ToInt32(Muell1) + Convert.ToDouble(Muell2);

        if ((Ergebnis3 > 100 && Ergebnis3 < 200) || Ergebnis3 == 300)
        {
            Console.WriteLine(Ergebnis3);
        }
        else if (Ergebnis3 < 100)
        {
            Console.WriteLine("Zahl ist kleiner als 100");
        }
        else if (Ergebnis3 > 200)
        {
            Console.WriteLine("Zahl ist größer als 200");
        }
    }
}