//Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu 
//wymyśloną kategorię wzrostu.
//Ex6
//Dane 140cm

int height = 0;

Console.WriteLine("Wybierz wzrost:");
Int32.TryParse(Console.ReadLine(), out height);

if (height >= 170 && height < 200)
{
    Console.WriteLine("Ty bydlaku!");
}
else if (height >=160 && height < 170)
{
    Console.WriteLine("Średniak");
}
else if (height >=140 && height < 160)
{
    Console.WriteLine("Jestes krasnoludem");
}
else if (height >=120 && height < 140)
{
    Console.WriteLine("Ty karakanie");
}
else if (height >=1 && height < 120) 
{
    Console.WriteLine("To już jest wielki problem");
}
else
{
    Console.WriteLine("Nie możesz podawać wartości minusowych oraz zerowych");
}

Console.WriteLine("Wciśnij dowolny przycisk, aby wyłączyć program");
Console.ReadKey();
Console.Clear();
