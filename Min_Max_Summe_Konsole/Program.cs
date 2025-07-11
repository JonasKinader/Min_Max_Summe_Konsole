namespace Min_Max_Summe_Konsole;

internal class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("KonsoleMinMax");
        Console.WriteLine();

        //leeres Array mit 10 plätzen anlegen
        int[] ar = new int[10];

        //Größe des Array zur Laufzeit ändern
        Array.Resize(ref ar, ar.Length);

        //Array anlegen mit Werten
        int[] werte = new int[] { 7, 5, 0, 18, 25, 14 };

        int summe = BerechneSumme(werte);
        Console.WriteLine("Die Summe der Werte lautet: " + summe);
        ArrayAnzeigen(werte);

        ArrayMitRandomFüllen(ar);
        int summe2 = BerechneSumme(ar);
        ArrayAnzeigen(ar);

        Console.WriteLine("Die Summe der Zufalswerte lautet: " + summe2);

        Console.ReadLine();
    }

    static int BerechneSumme(int[] values)
        {
            int summe = 0;

            for (int i = 0; i < values.Length; i++)
            {
                // zwischensumme bilden
                // summe = summe + werte[i]
                summe += values[i];
            }
            return summe;

        }

    static void ArrayMitRandomFüllen(int[] values)
    {
        // Zufallszahlengenerator anlegen
        Random r = new Random(123);

        for (int i = 0; i < values.Length; i++)
        {
            //Zufallswerte zwischen 1 und 100 erzeugen
            int nZufall = r.Next(1,101);
            values[i] = nZufall;
        }
        
    }

   static void ArrayAnzeigen(int[] values)
    {
        for (int i = 0;i < values.Length; i++)
        {
            Console.Write(values[i]+" ");
            Console.WriteLine();
        }   
    }

    static int MinWert(int[] values)
    {
        int min = values[0];
        for(int i = 0;i < values.Length; i++)
        {
            
            if (values[i] < min)
            {
               min = values[i]; 
            }
        }
        return min;
    }

    static int MaxWert(int[] values)
    {
        int max = values[0];
        for (int i = 0;i < values.Length; i++)
        {
            if(values[i] > max)
            {
                max = values[i];
            }
        }
        return max;
    }



}
