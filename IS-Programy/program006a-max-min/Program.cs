using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")
{


    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** Max a min  *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 13.11.2025 ******************");
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


    // kladna, zaporna nebo nuly
    int negativeNumbs = 0;
    int positiveNumbs = 0;
    int zeroes = 0;

    //suda nebo licha
    int evenNumbs = 0;
    int oddNumbs = 0;

    Console.WriteLine();
    Console.WriteLine("Nahodna cisla: ");
    for (int i = 0; i < n; i++)   //pole jsou indexovana od 0 - proto int = 0, zaroven proto i < n (a ne i<=n)
    {
        myRandNumbs[i] = myRandNumb.Next(LowerBound, UpperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }




    //hledani maxima, pozice maxima, minima, pozice minima
    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;
    //7; 5; 9;
    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max) // 5 > 7
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if (myRandNumbs[i] < min) // 7 < 5
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("==============================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima: {posMin}");
    Console.WriteLine("==============================================");
    Console.WriteLine();



    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
