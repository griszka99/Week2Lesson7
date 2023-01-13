//Wynik z Matury z matematyki powyżej 70
//Wynik z fizyki powyżej 55
//Wynik z chemii powyżej 45
//Łączny wynik z 3 przedmiotów powyżej 180
//Albo
//Wynik z matematyki i jednego przedmiotu powyżej 150
//Dane testowe:
//Matematyka 80
//Fizyka 71
//Chemia 0
//Ex 8

int Mathe = 80;
    Console.WriteLine("Podaj ilość punktów z matury z Matematyki:");
    Int32.TryParse(Console.ReadLine(), out Mathe);
int Phisic = 71;
    Console.WriteLine("Podaj ilość punktów z matury z Fizyki:");
    Int32.TryParse(Console.ReadLine() , out Phisic);
int Chemie = 0;
    Console.WriteLine("Podaj ilość punktów z matury z Chemi:");
    Int32.TryParse(Console.ReadLine(), out Chemie);

int lacznyWynik;
lacznyWynik = Mathe + Phisic + Chemie;

if (lacznyWynik >180 || Mathe >70 && Phisic >55 && Chemie >45 || Mathe+Phisic  >150 || Mathe+Chemie >150)
{
    Console.WriteLine("Zostałeś dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("Niestety, czeka Cię sierpień, nie dostałeś się na studia");
}

Console.WriteLine("\n\n Naciśnij dowolny przycisk, aby zamknąć program");
Console.ReadKey();
Console.Clear();
