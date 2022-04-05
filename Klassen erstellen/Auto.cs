
public class Auto
{
  
    private string Farbe { get; set; }
    private int PS { get; set; }
    private string Modell { get; set; }
    private int Geschwindigkeit { get; set; }


    public Auto(string farbe, int pS, string modell, int geschwindigkeit)
    {
        Farbe = farbe;
        PS = pS;
        Modell = modell;
        Geschwindigkeit = geschwindigkeit;
    }

    public void Beschreibung()
    {
        Console.WriteLine($"Ich bin ein {Modell}, habe {PS} PS, kann maximal {Geschwindigkeit} km/h fahren und bin {Farbe}");
    }
    public void SetFarbe(string farbe)
    {
        // if das eine farbe. 
        Farbe = farbe;
    }
}




//Basisklasse
//IP-Adresse, PORT, Name / Reset() {name} wurde gesrettet / DisplayText("Hallo") // Der Text auf dem Display wäre -> {"Hallo"}
//
//Netzteil SetVoltage(5) /
//Messgerät  messung = MesseVolage()