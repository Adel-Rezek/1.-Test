Console.Write("Wie viel grad haben wir? ");
string temp = Console.ReadLine();
double tempAlsDouble = double.Parse(temp);

string WetterZustand = 20 > tempAlsDouble ? "Schlechtes Wetter" : "Gutes Wetter";   // Ternary Operator
Console.WriteLine(WetterZustand);

Console.WriteLine();

switch (tempAlsDouble)
{
    case > 0:
        Console.WriteLine("angenehm");
        break;
    case < 30:
        Console.WriteLine("Programm fertig");
        break;
    default:
        Console.WriteLine("Programm fertig");
        break;


}

