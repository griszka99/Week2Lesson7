//Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, 
//która jest największa
//Ex 7
// dane: a:25 b:63 c:79;

int liczba1;
int liczba2;
int liczba3;

Console.WriteLine("Wybierz liczbe 1):");
    Int32.TryParse(Console.ReadLine(), out liczba1);
Console.WriteLine("Wybierz  liczbe 2):");
    Int32.TryParse(Console.ReadLine() , out liczba2);
Console.WriteLine("Wybierz liczbe 3):");
    Int32.TryParse(Console.ReadLine() ,out liczba3);

if (liczba1 > liczba2 && liczba1 > liczba3)
{
    Console.WriteLine($"liczba {liczba1} jest największa z podanych");
}
else if (liczba1 < liczba2 && liczba2 > liczba3)
{
    Console.WriteLine($";oczba {liczba2} jest największa z podanych");
}
else if (liczba3 > liczba1 && liczba3 > liczba2)
{
    Console.WriteLine($"liczba {liczba3} jest największa z podancyh");
}
else
{
    Console.WriteLine("nie wiem co tu wpisać ..:O");
}

Console.WriteLine("Wciśnij dowolny przycisk, aby zakończyć działanie programu");
Console.ReadKey();
Console.Clear();

    
