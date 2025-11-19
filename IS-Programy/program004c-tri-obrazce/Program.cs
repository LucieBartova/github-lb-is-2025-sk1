// --- 1. ČÁST: Zadání velikosti ---
Console.Write("Zadej velikost obrazce (číslo, např. 9): ");
string textVelikost = Console.ReadLine();
int velikost = int.Parse(textVelikost);

// --- 2. ČÁST: Výběr obrazce ---
Console.WriteLine("\nVyber si, který obrazec chceš vykreslit:");
Console.WriteLine("1 -> Obrazec 6 (Písmeno N)");
Console.WriteLine("2 -> Obrazec 19 (Obálka / Přesýpací hodiny)");
Console.WriteLine("3 -> Obrazec 15 (Kosočtverec)");
Console.Write("Tvoje volba (napiš 1, 2 nebo 3): ");

string textVolba = Console.ReadLine();
int volba = int.Parse(textVolba);

Console.WriteLine(); // Jen prázdný řádek pro mezeru

// --- 3. ČÁST: Rozhodování a vykreslování ---

if (volba == 1)
{
    // *** OBRAZEC 6 (Písmeno N) ***
    Console.WriteLine($"Vykresluji Písmeno N o velikosti {velikost}:");
    
    for (int radek = 0; radek < velikost; radek++)
    {
        for (int sloupec = 0; sloupec < velikost; sloupec++)
        {
            // Levý okraj NEBO pravý okraj NEBO šikmá čára
            if (sloupec == 0 || sloupec == velikost - 1 || radek == sloupec)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine(); // Odřádkování na konci řádku
    }
}
else if (volba == 2)
{
    // *** OBRAZEC 19 (Obálka) ***
    Console.WriteLine($"Vykresluji Obálku o velikosti {velikost}:");

    for (int radek = 0; radek < velikost; radek++)
    {
        for (int sloupec = 0; sloupec < velikost; sloupec++)
        {
            // Horní okraj NEBO Dolní okraj
            if (radek == 0 || radek == velikost - 1) 
            {
                Console.Write("* ");
            }
            // Hlavní diagonála (zleva nahoře)
            else if (radek == sloupec) 
            {
                Console.Write("* ");
            }
            // Vedlejší diagonála (zprava nahoře)
            else if (radek + sloupec == velikost - 1) 
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}
else if (volba == 3)
{
    // *** OBRAZEC 15 (Kosočtverec) ***
    Console.WriteLine($"Vykresluji Kosočtverec o velikosti {velikost}:");
    
    // Potřebujeme najít střed pro výpočet
    int stred = velikost / 2;

    for (int radek = 0; radek < velikost; radek++)
    {
        for (int sloupec = 0; sloupec < velikost; sloupec++)
        {
            // Spočítáme vzdálenost bodu od středu
            int vzdalenostRadek = Math.Abs(radek - stred);
            int vzdalenostSloupec = Math.Abs(sloupec - stred);

            // Pokud součet vzdáleností sedí, píšeme hvězdičku
            if (vzdalenostRadek + vzdalenostSloupec == stred)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}
else
{
    // Pokud uživatel zadal něco jiného než 1, 2, 3
    Console.WriteLine("To není platná volba. Musíš zadat 1, 2 nebo 3.");
}

// Čekání na stisk klávesy, aby se okno hned nezavřelo
Console.WriteLine("\nStiskni cokoliv pro ukončení...");
Console.ReadKey();
