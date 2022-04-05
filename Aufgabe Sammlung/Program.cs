Console.WriteLine("Hier ist ein Programm als Wiederholung für die ganze Funktionen und Befehle, die ich gelernt habe!");

//Variable als string defenieren, int, double, Eingabe, Ausgabe:

string userInput = String.Empty;
double counter = 0;          //Hier defeniere ich und deklariere counter für Angangen mit Wert 0.

//double userInputToDouble = double.Parse(userInput);    //Hier wandle ich um userInput von String auf double um und bekommt neue Name userInputAlsDouble.


do
{
    Console.Write("Geben Sie bitte ein Zahl ein: ");        //Hier ist eine Ausgabe was wird im Console stehen.
    userInput = Console.ReadLine();           //Hier ist userInput als Eingabe, kann man geben, den Wert was er will.
    bool isUserInputSucces = double.TryParse(userInput, out double userInputToDouble);
    if (isUserInputSucces)
    {

        if (userInputToDouble >= 1 && userInputToDouble <= 100)    //Hier soll der Variable userInputToDouble zwischen 1 und 100 sein,kleiner oder großer nicht erlaubt.
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Andere Zahl");
        }
    }
    else
    {
        Console.WriteLine("geben Sie ein Zahl ein");
    }
}
while (userInput != "k");

//Diese do - while Schleife ^| oben ist dass man ein Zahl eingibt, nicht kleiner wie 1 und nicht größer wie 100, und keine buchstabe,
//und mit k kann man das Programm enden.


