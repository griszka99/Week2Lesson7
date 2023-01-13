//Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek 
//uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
//prezydenta.
//dane: 21;
//Ex5:

string a = "prezydentem";
string b = "premierem"; //nie wiem ile trzeba mieć lat, wiec przyjąłem 30.
string c = "senatorem";
string d = "posłem";

int choice = 0;
Console.WriteLine("Podaj swój wiek, a dowiesz się, kim możesz zostać w rządzie");
Int32.TryParse(Console.ReadLine(), out choice);

if (choice >= 35)
{
    Console.WriteLine($"mając {choice} lat, możesz zostać {a}, {b}, {c}, oraz {d}");
}
else if (choice >= 30)
{
    Console.WriteLine($"mając {choice} lat, możesz zostać {b}, {c}, {d},");
}
else if (choice >= 21)
{
    Console.WriteLine($"majać {choice} lat, możesz zostać {d}");
}
else if (choice == 0)
{
    Console.WriteLine("Nie możesz podać takiego wyrażenia");
}
else
{
    Console.WriteLine("Masz za mało lat by zostać politykiem w rządzie");
}

Console.WriteLine("Wciśnij dowolny przycisk, aby zakończyć program");
Console.ReadKey();
Console.Clear();




                             
                     