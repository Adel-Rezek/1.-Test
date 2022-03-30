// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hallo, David!");
// 2 mal das dinge hier ist ein Kommentar und wird vom Compiler ignoriert 

/* das ist hier für ganze Block
 * 
 * 
 * 
 * 
 */


//Console.Writeline("") zeigt Text raus in Console//    
Console.WriteLine("");

//Variabeln können nur mit Buchstaben oder Unterstrich _ anfangel! Und  

//bool _bool = true;

//int _int = 1;

//string _string = "Hello World";

//char _char = 'c';

//double _double = 123.223;

//Console.WriteLine()







//Defenieren

int warm = 30;
int kalt = 2;

string WetterZustandSonnig = "sonnig";
string WetterZustandRegenrisch = "regenerisch";

string RegenschirmWarmesWetter = "keinen";
string RegenschirmKaltesWetter = "einen";

//String Verkettung:

string WarmesWetter = "Heute ist es " + WetterZustandSonnig + " du brauchst " + RegenschirmWarmesWetter + " Regenschirm" + " die Temperatur ist " + warm + "°C";
Console.WriteLine(WarmesWetter);

string KaltesWetter = "Heute ist es " + WetterZustandRegenrisch + " du brauchst " + RegenschirmKaltesWetter + " Regenschirm" + " die Temperatur ist " + kalt + "°C";
Console.WriteLine(KaltesWetter);

Console.WriteLine();

//String Interpolation:

Console.WriteLine($"Heute ist es {WetterZustandSonnig} du brauchst {RegenschirmWarmesWetter} Regenschirm die Temperatur ist {warm}°C");

Console.WriteLine($"Heute ist es {WetterZustandRegenrisch} du brauchst {RegenschirmKaltesWetter} Regenschirm die Temperator ist {kalt}°C");


Console.WriteLine();
Console.WriteLine("Bin Fertig, ich komme gleich :-)");


