

int a;
int b;
Console.WriteLine("Podaj pierwszą liczbę:");
Int32.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Podaj drugą liczbę");
Int32.TryParse(Console.ReadLine(), out b);
int wynik;

int operation;
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
Console.WriteLine("\n Wybierz metodę:");
Int32.TryParse(Console.ReadLine(), out operation);

if (operation > 4 || operation <= 0)
    {
        Console.WriteLine("Podałeś nieprawidłowy numer operacji");
    }

   else if (operation == 1)
{
    wynik = a + b;
    Console.WriteLine("Wynik dodawania: " + wynik + "");
}
else if (operation == 2)
{
    wynik = a - b;
    Console.WriteLine("Wynik odejmowania: " + wynik + "");
}
else if (operation == 3)
{
    wynik = a * b;
    Console.WriteLine("Wynik mnożenia " + wynik + "");
}
else if (operation ==4 && b==0)
{
    Console.WriteLine("Bład!!! Nigdy nie dziel przez 0");
}
else if (operation == 4)
{
    wynik = a / b;
    Console.WriteLine("Wynik dzielenia " + wynik + "");
}

else
{
    Console.WriteLine("Musisz podać cyfre!");
}
Console.WriteLine("\n Wciśnij doowlny przycisk, aby zakończyć program");
Console.ReadKey();
Console.Clear();




