using System;

class Program
{
    static void Main()
    {
        string[] slova = { "PROGRAM", "SOFTWARE", "KONZOLE", "DATA" };
        Random nahoda = new Random();
        string slovo = slova[nahoda.Next(slova.Length)];

        char[] maska = new char[slovo.Length];
        for (int i = 0; i < slovo.Length; i++)
        {
            maska[i] = '_';
        }

        int pokusy = 6;
        bool vyhra = false;

        while (pokusy > 0 && vyhra == false)
        {
            Console.Clear();
            Console.WriteLine("=== ŠIBENICE ===");
            Console.WriteLine();

            Console.Write("Slovo: ");
            for (int i = 0; i < maska.Length; i++)
            {
                Console.Write(maska[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Zbývající pokusy: " + pokusy);
            Console.Write("Zadej písmeno: ");

            string vstup = Console.ReadLine().ToUpper();
            if (vstup.Length == 0)
            {
                continue;
            }

            char pismeno = vstup[0];
            bool trefa = false;

            for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo[i] == pismeno)
                {
                    maska[i] = pismeno;
                    trefa = true;
                }
            }

            if (trefa == false)
            {
                pokusy--;
            }

            bool hotovo = true;
            for (int i = 0; i < maska.Length; i++)
            {
                if (maska[i] == '_')
                {
                    hotovo = false;
                }
            }

            if (hotovo == true)
            {
                vyhra = true;
            }
        }

        Console.Clear();
        if (vyhra == true)
        {
            Console.WriteLine("Vyhrála jsi!");
            Console.WriteLine("Slovo bylo: " + slovo);
        }
        else
        {
            Console.WriteLine("Prohrála jsi.");
            Console.WriteLine("Slovo bylo: " + slovo);
        }

        Console.WriteLine("Stiskni klávesu pro konec.");
        Console.ReadKey();
    }
}
