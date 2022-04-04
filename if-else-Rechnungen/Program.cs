//string ersterZahl = Console.ReadLine();
//string zweiterZahl = Console.ReadLine();



Console.Write("Geben Sie bitte den erster Zahl ein: ");
string ersterZahl = Console.ReadLine();
Console.WriteLine();
Console.Write("Geben Sie bitte den zwiter Zahl ein: ");
string zweiterZahl = Console.ReadLine();
//double ersterZahlToInt = double.Parse(ersterZahl);
//double zweiterZahlToInt = double.Parse(zweiterZahl);
bool isConvertToIntSuccses1 = double.TryParse(ersterZahl, out double ersterZahlToInt);
bool isConvertToIntSucsess2 = double.TryParse(zweiterZahl, out double zweiterZahlToInt);
Console.WriteLine();
Console.WriteLine();


if (isConvertToIntSuccses1 && isConvertToIntSucsess2)
{
    double ergibnisAdd = ersterZahlToInt + zweiterZahlToInt;
    Console.WriteLine($"Ergibnis addieren ist: {ergibnisAdd}");
    double ergibnisSub = ersterZahlToInt - zweiterZahlToInt;
    Console.WriteLine($"Ergibnis substrahieren ist: {ergibnisSub}");
    double ergibnisMult = ersterZahlToInt * zweiterZahlToInt;
    Console.WriteLine($"Ergibnis multiplizieren ist: {ergibnisMult}");
    
    if (zweiterZahlToInt != 0)
    {
        double ergibnisDev = ersterZahlToInt / zweiterZahlToInt;
        Console.WriteLine($"Ergibnis devision ist: {ergibnisDev}");
    }
    else
    {
        Console.WriteLine("Die Devision Rechnung kann nicht durchgeführt werden, weil die 2.Zahl darf nicht 0 sein, sonst eine andere Zahl");
    }
}
else
{
    Console.WriteLine("Könnte nicht gerechnet werden, bitte geben Sie eine Zahl ein und kein Buchstabe, um die Rechnung richtig durchzuführen!!");
}
Console.WriteLine();



//Beispiel:

int temper = 33;

string tolleWeternachricht = 22 > temper ? "Angenehme Temperat" : "Viel zu heeeeß!"; // Ternary Operator


if (22 > temper)
{
    tolleWeternachricht = "Angenehme Temperat";
}
else
{
    tolleWeternachricht = "Viel zu heeeiß!";
}

switch(temper) //Switch Statement
{
    case 0:
        Console.WriteLine("zu kalt");
        break;
    case 22:
        Console.WriteLine("Angenehm");
        break;
    default:
        Console.Write("irgendwas");
        break;
}