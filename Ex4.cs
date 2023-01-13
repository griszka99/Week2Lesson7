//Napisz program w C#, który sprawdzi czy podany przez użytkownika rok 
//jest rokiem przestępnym
//dane: 2016;
//Ex4:

int year = 0;
Console.WriteLine("Podaj rok, aby sprawdzić, czy jest rokiem przestępnym:");
Int32.TryParse(Console.ReadLine(), out year);

if (year % 4 == 0)
{
    Console.WriteLine("Podany rok: " + year + " jest rokiem przestępnym");
}
else if (year % 100 == 0)
{
    Console.WriteLine("Podany rok: " + year + " nie jest rokiem przestępnym");
}
else if (year % 400 == 0)
{
    Console.WriteLine("Podany rok: " + year + " jest rokiem przestępnym");
}


else
{
    Console.WriteLine("Podany rok: " + year + " nie jest rokiem przestępnym");
}
Console.WriteLine("Wciśnij dowolny przycisk, by zamknąć program");
Console.ReadKey();
Console.Clear();