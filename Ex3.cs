//Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
//jest dodatnia czy ujemna.
//Ex3
//Sprawdz na liczbie: 14;

int liczba = 0;
Console.WriteLine("Wpisz liczbę, by sprawdzić, czy jest dodatnia lub ujemna");
Int32.TryParse(Console.ReadLine(), out liczba);

if (liczba >0)
{
    Console.WriteLine($"Liczba {liczba}, jest dodatnia");
}
    else if (liczba <0)
{
    Console.WriteLine($"Liczba {liczba}, jest ujemna");
}
else
{
    Console.WriteLine("Podana liczba nie jest dodatnia, ani ujemna, jest zerem"); 
}

Console.WriteLine("Naciśnij dowolny przycisk, by zakończyć program");
Console.ReadKey();
Console.Clear();