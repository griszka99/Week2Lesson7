//Temp < 0 – cholernie piździ
//Temp 0 – 10 – zimno
//Temp 10 – 20 – chłodno
//Temp 20 – 30 – w sam raz
//Temp 30 – 40 – zaczyna być słabo, bo gorąco
//Temp >= 40 - a weź wyporowadzam się na Alaske
//Ex 9
int temp;
Console.WriteLine("Podaj temperatuje");
Int32.TryParse(Console.ReadLine(), out temp);
string minus = "Cholernie piździ";
string zimno ="zimno";
string chłodno ="chłodno";
string wSamRaz = "w sam raz";
string gorąco ="zaczyna być słabo, bo gorąco";
string upal = "a weź, wyprowadzam się na Alaske";

if (temp >= 40)
{
    Console.WriteLine($"{upal}");
}
    else if (temp <40 && temp >=30)
    {
        Console.WriteLine(gorąco);
    }
    else if (temp <30 && temp>=20)
    {
         Console.WriteLine(wSamRaz);
    }
    else if (temp <20 && temp >=10)
    {
         Console.WriteLine(chłodno);
    }
    else if (temp <10 && temp>=0)
    {
        Console.WriteLine(zimno);
    }
else
{
    Console.WriteLine(minus);
}

