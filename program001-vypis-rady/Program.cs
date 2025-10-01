string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine("lucinka");
    Console.WriteLine("pusinka");
    Console.WriteLine("********************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešení
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.WriteLine("Zadejte první číslo řady (celé číslo)");
int first;

    while (!int.TryParse(Console.ReadLine(), out first));
    {
        Console.Write("Nezadali jste celé číslo. Zadejte prví číslo řady znovu:");
}



        Console.WriteLine();
    Console.WriteLine("Pro opakovani programu stisknete klavesu a.");
    again = Console.ReadLine();
}