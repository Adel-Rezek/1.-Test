Console.WriteLine("                                               Mathe Aufgaben:");
Console.WriteLine();

Console.WriteLine("Der Programm wird Mathematische Rechnungen führen: addieren - subtrahieren - multiplezieren - devision :) ");
Console.WriteLine();


Console.WriteLine("* 1. Aufgabe (addieren): ");
Console.Write("Geben Sie bitte die erster Zahl ein: ");
string ersterZahl = Console.ReadLine();
Console.Write("Geben Sie nun den zweiter Zahl ein: ");
string zweiterZahl = Console.ReadLine();

int ersterZahlAlsInt = int.Parse(ersterZahl);
int zweiterZahlAlsInt = int.Parse(zweiterZahl);

int ergibnis = ersterZahlAlsInt + zweiterZahlAlsInt;
Console.WriteLine($"Das Ergibnis ist: {ergibnis} ");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("* 2. Aufgabe (subtrahieren): ");
Console.Write("Geben Sie bitte die erster Zahl ein: ");
string ersterZahl1 = Console.ReadLine();
Console.Write("Geben Sie nun den zweiter Zahl ein: ");
string zweiterZahl1 = Console.ReadLine();

int ersterZahlAlsInt1 = int.Parse(ersterZahl1);
int zweiterZahlAlsInt1 = int.Parse(zweiterZahl1);

int ergibnis1 = ersterZahlAlsInt1 - zweiterZahlAlsInt1;
Console.WriteLine($"Das Ergibnis ist: {ergibnis1} ");


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("* 3. Aufgabe (multiplezieren): ");
Console.Write("Geben Sie bitte die erster Zahl ein: ");
string ersterZahl2 = Console.ReadLine();
Console.Write("Geben Sie nun den zweiter Zahl ein: ");
string zweiterZahl2 = Console.ReadLine();

int ersterZahlAlsInt2 = int.Parse(ersterZahl2);
int zweiterZahlAlsInt2 = int.Parse(zweiterZahl2);

int ergibnis2 = ersterZahlAlsInt2 * zweiterZahlAlsInt2;
Console.WriteLine($"Das Ergibnis ist: {ergibnis2} ");



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("* 4. Aufgabe (devision): ");
Console.Write("Geben Sie bitte die erster Zahl ein: ");
string ersterZahl3 = Console.ReadLine();
Console.Write("Geben Sie nun den zweiter Zahl ein: ");
string zweiterZahl3 = Console.ReadLine();

int ersterZahlAlsInt3 = int.Parse(ersterZahl3);
int zweiterZahlAlsInt3 = int.Parse(zweiterZahl3);

double ergibnis3 = ersterZahlAlsInt3 / zweiterZahlAlsInt3;
Console.WriteLine($"Das Ergibnis ist: {ergibnis3} ");

Console.WriteLine();

Console.WriteLine("Das war's");



