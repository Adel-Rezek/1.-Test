Console.WriteLine("                                          - Mathe Aufgaben -");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Das Programm wird matematische Rechnungen durchfüren und ausrechnen.");
Console.WriteLine();
Console.WriteLine();



Console.WriteLine("* 1. Aufgabe (addieren): ");
Console.Write("Geben Sie bitte den erster Zahl ein: ");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("* 2. Aufgabe (substrahieren): ");
Console.Write("Geben Sie bitte den erster Zahl ein: ");
;
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("* 3. Aufgabe (multiplizieren): ");
Console.Write("Geben Sie bitte den erster Zahl ein: ");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("* 4. Aufgabe (division): ");
Console.Write("Geben Sie bitte den erster Zahl ein: ");


string ersterZahl = Console.ReadLine();






Console.Write("Und jetzt geben Sie bitte den zweiter Zahl ein: ");
string zweiterZahl = Console.ReadLine();




int ersterZahlAlsInt = int.Parse(ersterZahl);
int zweiterZahlAlsInt = int.Parse(zweiterZahl);
int ergibnis = ersterZahlAlsInt + zweiterZahlAlsInt;
Console.WriteLine($"Das Ergibnis ist: {ergibnis}");



