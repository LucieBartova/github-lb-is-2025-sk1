using System;

    
    
        Console.Write("Zadejte celé číslo: ");
        int number = int.Parse(Console.ReadLine());
        int n = number; // uložíme původní číslo

        if (n < 0) n = -n; // vezmeme absolutní hodnotu

        int sum = 0;
        int product = 1;

        while (n > 0)
        {
            int digit = n % 10; // vezmeme poslední cifru
            sum += digit;       // přičteme do součtu
            product *= digit;   // vynásobíme do součinu
            n /= 10;            // odstraníme poslední cifru
        }

        Console.WriteLine("Součet cifer čísla {0} je {1}", number, sum);
        Console.WriteLine("Součin cifer čísla {0} je {1}", number, product);
    

