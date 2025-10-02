string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********** Výpis číselné řady **************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 2.10.2025 ******************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();

    //Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());


    //Console.WriteLine();
    //Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    //again = Console.ReadLine();




    //Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte první číslo řady: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte prvni cislo rady znovu: ");
    } 




}