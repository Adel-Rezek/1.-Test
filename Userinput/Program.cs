//Console.Write("Zahl1: ");
//string InputZahl1 = Console.ReadLine()
//Console.Write("Zahl2: ");
//string InputZahl2 = Console.ReadLine();

//int Zahl1 = int.Parse(InputZahl1);
//int Zahl2 = int.Parse(InputZahl2);

//Console.WriteLine(Zahl1 + Zahl2);



Console.WriteLine("Ich multipliziere 2 Zahlen für dich.");





Console.Write($"Gib bitte die erster Zahl ein: ");
string ersterZahl = Console.ReadLine();

Console.Write($"Gib nun bitte die zweiter Zahl ein: ");
string zweiterZahl = Console.ReadLine();

int ersterZahlAlsInt = int.Parse(ersterZahl);
int zweiterZahlAlsInt = int.Parse(zweiterZahl);


int Ergibnis = ersterZahlAlsInt * zweiterZahlAlsInt;
Console.WriteLine($"{ersterZahl} * {zweiterZahl} = {Ergibnis}");

Console.WriteLine($"Das Produkt aus {ersterZahl} und {zweiterZahl} ist {Ergibnis}");
