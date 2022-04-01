Console.WriteLine("Geben sie Zahlen ein, NUR von 1 bis 6! ");
Console.WriteLine();
Console.WriteLine();

string ersterZahl = "";
string zweiterZahl = "";
string durchschnitt = "";


//while (true)

    Console.Write("Der erste Zahl ist: ");
    double ersterZahlAlDouble = double.Parse(ersterZahl);
    ersterZahl = Console.ReadLine();
    Console.Write("Der zweite zahl ist: ");
    double zweiterZahlAlDouble = double.Parse(zweiterZahl);
    zweiterZahl = Console.ReadLine();
    Console.WriteLine("Der Durchschnitt ist: ");
    double durchschnittAlsDouble = double.Parse(durchschnitt);
    durchschnittAlsDouble = ersterZahlAlDouble  + zweiterZahlAlDouble / 2;
    Console.WriteLine();
    

    


