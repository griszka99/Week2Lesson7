//Ex2, Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba 
//jest parzysta czy nieparzysta.
// sprawdz na liczbie 15,

int liczba=0;
Console.WriteLine("Podaj liczbe, by sprawdzić, czy jest ona parzysta");
Int32.TryParse(Console.ReadLine(), out liczba);

if (liczba %2 == 0)
{
    Console.WriteLine("Podana liczba " + liczba + " jest parzysta");
}
else
{
    Console.WriteLine("Podana Liczba " + liczba + ", nie jest parzysta");
}

Console.WriteLine("Naciśnij dowolny przycisk, by zakończyć program");
Console.ReadKey();
Console.Clear();
