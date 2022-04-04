string ersterZahl = String.Empty;

string zweiterzahl = String.Empty;


while (true)
      
{
   

    ersterZahl = Console.ReadLine();
    double ersterZahlAlsDouble = double.Parse(ersterZahl);

    zweiterzahl = Console.ReadLine();
    double zwiterZahlAlsDouble = double.Parse(zweiterzahl);

    double durchschnitt = (ersterZahlAlsDouble + zwiterZahlAlsDouble) / 2;
    Console.WriteLine(durchschnitt);

}