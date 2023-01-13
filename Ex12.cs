// Napisz program, który pobierze numer dnia tygodnia i wyświetli jego 
//nazwę
//Ex 12:

int dzienTygodnia;
Console.WriteLine("Podaj liczbe:");
Int32.TryParse(Console.ReadLine(),out dzienTygodnia);

switch (dzienTygodnia)
{
    case 1: Console.WriteLine("poniedziałek");
        break;

        case 2: Console.WriteLine("Wtorek");
        break;

        case 3: Console.WriteLine("Środa");
        break;

        case 4: Console.WriteLine("Czwartek");
        break;

        case 5: Console.WriteLine("Piątek");
        break;

        case 6: Console.WriteLine("Sobota");
        break;

        case 7: Console.WriteLine("Niedziela");
        break;

        default: Console.WriteLine("Nie można wybierać liter");
        break;
        
}
Console.WriteLine("\n Wciśnij dowolny przycisk, by zakonczyć program");
Console.ReadKey();
Console.Clear();
