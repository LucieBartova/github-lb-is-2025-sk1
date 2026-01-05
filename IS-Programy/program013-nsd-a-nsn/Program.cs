﻿
/* Hlavní program - začátek */

string again = "a";
while (again == "a")
{
    Console.Clear();

    // Metoda pro razítko - hlavičku
    razitko();
    
    // Načítání hodnot
    ulong a = nactiCislo("Zadejte číslo a: ");
    ulong b = nactiCislo("Zadejte číslo b: ");

    ulong nsd = vypocitatNSD(a, b);
    ulong nsn = vypocitatNSN(a, b, nsd); 

    zobrazitVysledky(a, b, nsd, nsn);

    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}

/* Hlavní program - konec */

/* metoda která nic nevrací - nevrací hodnotu */
static void razitko()
{
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpočet NSD a NSN *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Lucie Bártová ********");
    Console.WriteLine("****************************");
    Console.WriteLine();
}    

/* metoda pro načtení čísel */
static ulong nactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

    // !!! Metoda, která vrací nějaký konkrétní datový typ, musí obsahovat následující řádek
    return cislo;

}

/* metoda pro výpočet NSD dvou čísel */
static ulong vypocitatNSD(ulong a, ulong b) {
    while(a != b ) {
        if(a > b)
            a = a - b;
        else
            b = b - a;    
    }
    return a;   
}

/* metoda pro výpočet NSN na základě známé hodnoty NSD */
static ulong vypocitatNSN(ulong a, ulong b, ulong nsd) {
    return (a*b)/nsd;
}

/* metoda pro zobrazení výsledků */
static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("================================");
    Console.WriteLine("NSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("================================");
    Console.WriteLine("NSN čísel {0} a {1} je {2}", a, b, nsn);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}