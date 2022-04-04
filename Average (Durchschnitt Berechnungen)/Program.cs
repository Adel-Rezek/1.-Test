Console.WriteLine("Geben sie Zahlen ein, NUR von 1 bis 6! ");
Console.WriteLine();
Console.WriteLine();

//string n = "";
//string b = "";
//double naa = double.Parse(n);
//double baa = double.Parse(b);
//while (naa < 9)

//int kleineZahl = 1;
//int großeZahle = 6;
//Console.WriteLine(Math.Min(großeZahle, kleineZahl));

while (true)
{
    Console.Write("Der erste Zahl ist: ");
    string ersterZahl = Console.ReadLine();
    double ersterZahlAlDouble = double.Parse(ersterZahl);
    if (ersterZahlAlDouble >= 1 && ersterZahlAlDouble <= 6)
    {
        
    }
    else
    {
        Console.WriteLine("Ungültig");
    }
    Console.Write("Der zweite zahl ist: ");
    string zweiterZahl = Console.ReadLine();
    double zweiterZahlAlDouble = double.Parse(zweiterZahl);
    if (zweiterZahlAlDouble >=1 && zweiterZahlAlDouble <=6)
    {

    }
    else
    {
        Console.WriteLine("Ungültig");
    }
    double durchschnitt = (ersterZahlAlDouble + zweiterZahlAlDouble) / 2;
    if (durchschnitt >= 1 && durchschnitt <= 6)
    {
        Console.WriteLine($"Der Durchschnitt ist {durchschnitt}");
    }
    else
    {
        Console.WriteLine("Der Durchschnitt ist Ungültig");
    }
    
    Console.WriteLine();
}






