int warm = 30;
int kalt = 2;

int aktuelleTemperatur = 40;

string wetterZustand;
string regenschirmGebrauch;

if (aktuelleTemperatur < 25)
{
    regenschirmGebrauch = "einen";
    wetterZustand = "Regenerisch";
}
else
{
    regenschirmGebrauch = "keinen";
    wetterZustand = "Sonnig";
}




//String Verkettung:

//string WarmesWetter = "Heute ist es " + wetterZustand + " du brauchst " + RegenschirmWarmesWetter + " Regenschirm" + " die Temperatur ist " + warm + "°C";
//Console.WriteLine(WarmesWetter);

//string KaltesWetter = "Heute ist es " + wetterZustand + " du brauchst " + RegenschirmKaltesWetter + " Regenschirm" + " die Temperatur ist " + kalt + "°C";
//Console.WriteLine(KaltesWetter);

Console.WriteLine();

//String Interpolation:

Console.WriteLine($"Heute ist es {wetterZustand} du brauchst {regenschirmGebrauch} Regenschirm die Temperatur ist {aktuelleTemperatur}°C");

//Console.WriteLine($"Heute ist es {WetterZustandRegenrisch} du brauchst {RegenschirmKaltesWetter} Regenschirm die Temperator ist {kalt}°C");


//Console.WriteLine();
//Console.WriteLine("Bin Fertig, ich komme gleich :-)");



//Console.WriteLine("5" + "5")     // Hier erkennt sich selber dass ist ein String ist und ergibt dann -> 55

//Console.WriteLine(5 + 5);        // Hier erkennt sich selber dass ist eine Int ist und ergibt dann -> 10





//string Userinput = Console.ReadLine();