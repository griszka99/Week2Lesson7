//Napisz program, który sprawdzi, czy z 3 podanych długości można 
//stworzyć trójkąt
//Dane testowe : 40 55 65

int a;
int b;
int c;
Console.WriteLine("Podaj długość boku a:");
Int32.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Podaj długość boku b:");
Int32.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Podaj długość boku c:");
Int32.TryParse(Console.ReadLine(), out c);

if (a+b>c || a+c>b || c+b>a)
{
    Console.WriteLine("podane boki utworzą trójkąt");
}
else
{
    Console.WriteLine("Podane boki nie utworzą trójkąta");
}

Console.WriteLine("Naciśnij dowolny przycisk, aby zakonczyc działanie programu");
Console.ReadKey();
Console.Clear();