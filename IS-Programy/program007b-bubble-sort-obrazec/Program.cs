using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("*********** Bubble Sort obrazec ***********");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************** Lucie Bártová **************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0;
    int change = 0;

    // Algoritmus Bubble sort
    myStopwatch.Start();
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
        }
    }
    myStopwatch.Stop();

    // Výpis seřazených čísel
    Console.WriteLine();
    Console.WriteLine("================================");    
    Console.WriteLine();
    Console.WriteLine("Seřazená čísla: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    // Nalezení druhého největšího čísla
    int secondLargest = myRandNumbs[0];
    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] < myRandNumbs[0])
        {
            secondLargest = myRandNumbs[i];
            break;
        }
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet výměn: {change}");
    Console.WriteLine("Čas potřebný na seřazení čísel: {0}", myStopwatch.Elapsed);
    Console.WriteLine($"Druhé největší číslo je {secondLargest}.");

    // Vykreslení obrazce
    Console.WriteLine();
    Console.WriteLine("Obrazec:");
    Console.WriteLine();

    int height = secondLargest;
    int width = 12; // Šířka obrazce

    // Horní okraj
    for (int i = 0; i < width; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

    // Střed obrazce
    for (int row = 0; row < height - 2; row++)
    {
        Console.Write("*");
        for (int col = 0; col < width - 2; col++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }

    // Dolní okraj (pouze pokud je výška větší než 1)
    if (height > 1)
    {
        for (int i = 0; i < width; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}