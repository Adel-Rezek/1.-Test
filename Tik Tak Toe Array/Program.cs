int[,] spielFeld =
    {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
    };


int spielStart;
string spielEnd;
int zähler = 0;
int i;
int j;

for (i = 0; i < spielFeld.GetLength(0); i++)
{
    for (j = 0; j < spielFeld.GetLength(1); j++)
    {
        zähler++;
        Console.WriteLine(spielFeld[i, j]);

    }

}


string ergibnis;
if (zähler == 5)
{

}

string ersterSpielerString = String.Empty;
string zweiterSpielerString = String.Empty;
//Console.Write("1. Spieler: ");
//string ersterSpieler = Console.ReadLine();
Console.WriteLine();
//Console.Write("2. Spieler: ");
//string zweiterSpieler = Console.ReadLine();
bool ersterSpielerBool = int.TryParse(ersterSpielerString, out int ersterSpielerInt);
bool zweiterSpielerBool = int.TryParse(zweiterSpielerString, out int zweiterSpielerInt);
Console.WriteLine();
Console.WriteLine();

for (i = 0; i < spielFeld.GetLength(0); i++)
{
    Console.Write("1. Spieler: ");
    Console.ReadLine();
    if (ersterSpielerBool && zweiterSpielerBool)
    {
        Console.WriteLine("Gültig");
    }
    else
    {
        Console.WriteLine("Ungültig");
    }
}
while (false) ;

for (j = 0; j < spielFeld.GetLength(1); j++)
{
    Console.Write("2. Spieler: ");
    Console.ReadLine();
    if (zweiterSpielerBool)
    {
        Console.WriteLine("Gültig");
    }
    else
    {
        Console.WriteLine("Ungültig");

    }

}
while (false) ;