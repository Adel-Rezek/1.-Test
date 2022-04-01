//int warm = 30;
//int kalt = 2;

Console.Write($"Es ist jetzt: ");
string aktuelleTemperatur = Console.ReadLine();
//int aktuelleTemperaturAlsInt = int.Parse(aktuelleTemperatur);


 bool isConvertToIntSuccess = int.TryParse(aktuelleTemperatur, out int aktuelleTemperaturAlsInt);


if (isConvertToIntSuccess)
{
    string wetterZustand;
    string regenschirmGebrauch;

    if (aktuelleTemperaturAlsInt <= 25)
    {
        regenschirmGebrauch = "einen";
        wetterZustand = "regenerisch";
    }
    else
    {
        regenschirmGebrauch = "keinen";
        wetterZustand = "sonnig";
    }

    Console.WriteLine($"Heute ist es {wetterZustand} du brauchst {regenschirmGebrauch} Regenschirm die Temperatur ist {aktuelleTemperaturAlsInt}°C");
}
else
{
    Console.WriteLine("Du sollte eine Zahl eingeben depp!");
}



//String Verkettung:

//string WarmesWetter = "Heute ist es " + wetterZustand + " du brauchst " + RegenschirmWarmesWetter + " Regenschirm" + " die Temperatur ist " + warm + "°C";
//Console.WriteLine(WarmesWetter);

//string KaltesWetter = "Heute ist es " + wetterZustand + " du brauchst " + RegenschirmKaltesWetter + " Regenschirm" + " die Temperatur ist " + kalt + "°C";
//Console.WriteLine(KaltesWetter);

Console.WriteLine();

//String Interpolation:



//Console.WriteLine($"Heute ist es {WetterZustandRegenrisch} du brauchst {RegenschirmKaltesWetter} Regenschirm die Temperator ist {kalt}°C");


//Console.WriteLine();
//Console.WriteLine("Bin Fertig, ich komme gleich :-)");



//Console.WriteLine("5" + "5")     // Hier erkennt sich selber dass ist ein String ist und ergibt dann -> 55

//Console.WriteLine(5 + 5);        // Hier erkennt sich selber dass ist eine Int ist und ergibt dann -> 10





//string Userinput = Console.ReadLine();

