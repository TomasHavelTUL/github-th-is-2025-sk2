string again = "a";
while (again == "a")
{


    Console.WriteLine("*********************************************");
    Console.WriteLine("*********** Součet cifer **************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Tomáš Havel *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("**************** 16.10.2025 ******************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();


    Console.WriteLine("Zadejte cele cislo:");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Nezadali jste cele cislo. Zadejte ho znovu: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit;

    // Pokud je vstup zaporny, tak ho zmenime na kladny
    if (number < 0)
    {
        number = -number;
    }

    while(number >= 10){
        digit = number % 10; // urcite se nam zbytek
        number = (number - digit) / 10; //(236-6) /10 = (230)/10 = 23
        Console.WriteLine("Hodnota zbytku = {0}", digit);
        suma = suma + digit;
    }

    // Musime posledni cifru vypsat
    Console.WriteLine("Posledni zbytek = {0}", number);

    // musime posledni cifru pricist
    suma = suma + number;

    Console.WriteLine("Soucet cifer cisla {0} je {1}", numberBackup, suma);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}