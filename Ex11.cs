//Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
//3; dostateczny
//Ex11

int ocena;
Console.WriteLine("Podaj ocene:");
Int32.TryParse(Console.ReadLine(), out ocena);

switch (ocena)
{
    case 1: Console.WriteLine("niedostateczny");
        break;

    case 2: Console.WriteLine("dopuszczający");
        break;

    case 3: Console.WriteLine("dostateczny");
        break;

    case 4: Console.WriteLine("dobry");
        break;

    case 5: Console.WriteLine("bardzo dobry");
        break;

    case 6: Console.WriteLine("celujący");
        break;
}

Console.Write("Wciśnij dowolny przycisk, by zakonczyc program");
Console.ReadKey();
Console.Clear();
