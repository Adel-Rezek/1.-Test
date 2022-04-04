

string userInput = String.Empty;
int counter = 0;
double sum = 0;

do
{
    Console.Write("Geben Sie einen Zahl ein: ");
    userInput = Console.ReadLine();

    bool isUserInputCorrect = double.TryParse(userInput, out double userInputDouble);
    if (isUserInputCorrect)
    {
        if (userInputDouble >= 0 && userInputDouble <= 6)
        {
            counter++;
            sum += userInputDouble;
            Console.WriteLine($"{userInputDouble} wurde addiert, es wurde {counter} Scores addiert, der aktuelle Durchschnitt ist: {sum / counter } ");
        }
        else
        {
            Console.WriteLine("Bitte geben Sie nur Zahlen zwichen 1 - 6 !");
        }
    }
    else
    {
        Console.WriteLine("Bitte geben Sie nur Zahlen ein und keine Buchstaben!");
    }
} while (userInput != "k");

