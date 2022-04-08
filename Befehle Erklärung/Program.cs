Console.WriteLine("Hier ist ein Programm als Wiederholung für die ganze Funktionen und Befehle, die ich gelernt habe!");

//Variable als string defenieren, int, double, Eingabe, Ausgabe:

string userInput = String.Empty;
double counter = 0;          //Hier defeniere ich und deklariere counter für Angangen mit Wert 0.

//double userInputToDouble = double.Parse(userInput);    //Hier wandle ich um userInput von String auf double um und bekommt neue Name userInputAlsDouble.


//--------------------------------------------------------------------------------------------------------------------------------------------------------


//do

//{

//    Inhalt

//} while (Bedingung);

//Wird zumindest einmal durchgeführt, dass die Schleife mit dem Schlüsselwort „do“ gestartet wird.
//Anschließend kommt der auzuführende Codeblock und am Ende wird mit dem Schlüsselwort „while“ geprüft,
//ob die genannte Bedingung erfüllt ist und der Code nochmal ausgeführt werden soll.(wenn true ist dann wird wieder durchgeführt, wenn false dann springt
//auf nächste Schleife und Schritt.

do   //wird zumindest einmal die Schleife gespielt, 
{
    //Console.Write("Geben Sie bitte ein Zahl ein: ");        //Hier ist eine Ausgabe was wird im Console stehen.
    userInput = Console.ReadLine();           //Hier ist userInput als Eingabe, kann man geben, den Wert was er will.
    bool isUserInputSucces = double.TryParse(userInput, out double userInputToDouble); // Hier soll von double auf bool umwandeln, und Ausgabe ist: isUserInputSucces
    if (isUserInputSucces)
    {

        if (userInputToDouble >= 1 && userInputToDouble <= 100)    //Hier soll der Variable userInputToDouble zwischen 1 und 100 sein,kleiner oder großer nicht erlaubt.
        {
            //Console.WriteLine();
        }
        else
        {
            //Console.WriteLine("Andere Zahl"); //sonst muss man andere Zahl eingeben!
        }
    }
    else
    {
        //Console.WriteLine("Kein Buchstabe!"); // Erlaub kein Buchstabe!
    }
}
while (true); // while (unserInput != k); Programm enden!

//Diese do - while Schleife ^| oben, wird zumindest einamal durchgeführt,  ist dass man ein Zahl eingibt, nicht kleiner wie 1 und nicht größer wie 100,
//und keine buchstabe. Wenn while true ist dann wird wieder und wieder durchgefürht, wenn false dann bricht ab!
//und mit k kann man das Programm enden.

//------------------------------------------------------------------------------------------------------------------------------------------------------


//while (condition) 
//{
//     //code block to be executed
//}


int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

// while Schleife: wird die Schleife durchgeführt sobald while true ist, und bricht ab wenn while false ist!


//-------------------------------------------------------------------------------------------------------------------------------------------------------