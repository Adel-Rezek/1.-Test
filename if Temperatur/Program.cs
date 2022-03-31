//Console.Write("Welche temperatur haben wir grade? ");
//string wieVielGrad = Console.ReadLine();
//double wieVielGradAlsDouble = double.Parse(wieVielGrad);


//if (wieVielGradAlsDouble > 24)
//{
//    Console.WriteLine($"Das Wetter ist scheiße, es ist {wieVielGradAlsDouble}°C ");
//}
//else if (wieVielGradAlsDouble < 15)
//{
//    Console.WriteLine($"Das Wetter ist angenehm, es ist {wieVielGradAlsDouble}°C ");
//}
//else if (wieVielGradAlsDouble == 20)
//{
//    Console.WriteLine($"Das Wetter ist zu heiß, es ist {wieVielGradAlsDouble}°C ");
//}
//else
//{
//    Console.WriteLine($"es ist { wieVielGradAlsDouble}°C ,Dann gehe halt Nachhause");
//}




//Console.Write("Das Temperator jetzt ist:  ");
//string temp = Console.ReadLine();
//double tempAlsDouble = double.Parse(temp);



//if (tempAlsDouble < 24 && tempAlsDouble > 16)
//{
//    Console.WriteLine("Es ist warm, Du musst ein Bier trinken!");
//}
//else
//{
//    Console.WriteLine("Gehe schlafen!");
//}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.Write("Du bist ein: ");
string userInput = Console.ReadLine();

bool isAzubi = false;
bool isPraktikant = false;
if (userInput == "Azubi")
{
    Console.WriteLine("Hol mir ein Bier!");
    isAzubi = true;
}
else if (userInput == "Praktikant")
{
    string sinvollerText = "Hol mir ein Bier!";

    Console.WriteLine(sinvollerText);
    isPraktikant = true;

}
else
{
    string sinvollerText = "Du musst dich weiterbilden!";
    Console.WriteLine(sinvollerText);
}


if (isAzubi || isPraktikant)
{
    Console.WriteLine("Hol mir ein Bier!");
}
else
{
    Console.WriteLine("Ich habe dich nicht gerufen!");
}
