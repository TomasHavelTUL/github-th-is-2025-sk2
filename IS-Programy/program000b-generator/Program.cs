using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{


    Console.WriteLine("*********************************************");
    Console.WriteLine("****** Generator pseudonahodnych cisel ******");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 6.11.2025 ******************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();

    Console.WriteLine("Zadejte pocet generovanych cisel");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte pocet cisel znovu");
    }

    Console.Write("Zadejte dolni mez (cele cislo): ");
    int LowerBound;
    while (!int.TryParse(Console.ReadLine(), out LowerBound))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte pocet cisel znovu");
    }


    Console.Write("Zadejte horni mez (cele cislo): ");
    int UpperBound;
    while (!int.TryParse(Console.ReadLine(), out UpperBound))
    {
        Console.Write("Nezadali jste cele cislo. Zadejte pocet cisel znovu");
    }




    Console.WriteLine();
    Console.WriteLine("=================================================");
    Console.WriteLine("Zadane hodnoty: ");
    Console.WriteLine("Pocet cisel: {0}, Dolni mez: {1}, Horni mez: {2}", n, LowerBound, UpperBound);
    Console.WriteLine("=================================================");
    Console.WriteLine();
    Console.WriteLine("=================================================");



    //deklarace pole (array)
    int[] myRandNumbs = new int[n];

    //priprava pro vyuziti tridy Random
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("Nahodna cisla: ");
    for (int i = 0; i < n ;i++)   //pole jsou indexovana od 0 - proto int = 0, zaroven proto i < n (a ne i<=n)
    {
        myRandNumbs[i] = myRandNumb.Next(LowerBound, UpperBound+1);
        Console.Write("{0}; ",myRandNumbs[i]);
    }









    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
