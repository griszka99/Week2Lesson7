//Ex1 week2Lesson7
//dane: a=14 b=14
//Sprawdz czy dane są takie same

using System.Security.Cryptography;

int a = 0;
int b = 0;

Console.WriteLine("Podaj liczbę a:");
Int32.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Podaj liczbę b:");
Int32.TryParse(Console.ReadLine(), out b);

if (a ==b)
{
    Console.WriteLine("Podane liczby są takie same");
}
else
{
    Console.WriteLine("Podane liczby różnią się od siebie");
}
