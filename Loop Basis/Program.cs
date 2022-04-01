

//int bla = 5;
//int bla2 = 7;
//bla++; bla = bla + 1;
//bla--; bla = bla - 1;

//bla += 6; bla = bla * 6;
//bla *= bla2;


for (int i = 5; i < 10; i += 2)
{
    Console.WriteLine($"Hallo, ich war heute schon {i} mal rauchen.");
    continue;
    Console.WriteLine("A");
}


//von 17 bis 123 alle ungeraden zahlen

//for(int i =17;i<123;i+=2)
//{
//    Console.WriteLine($"Die ungerade Zahlen sind: {i}");
//}

//Console.WriteLine();

//for(int i =16;i<123;i+=2)
//{
//    Console.WriteLine($"Die gerade Zahlne sind: {i}");
//}

//int j = 0;

//while (j <10)
//{
//    Console.WriteLine(j);
//    j++;
//}

//while (true)
//{
//    Console.WriteLine("DAS WIRD NIE ENDEN");
//}

do
{

}while (false);

string ersteZahl =String.Empty;


while (ersteZahl != "-1")
{
    Console.Write("Geben Sie bitte den erste Zahl ein: ");
     ersteZahl = Console.ReadLine();
    double ersterZahlAlsInt = double.Parse(ersteZahl);
    Console.WriteLine();
    Console.Write("Geben Sie bitte den zweiter Zahl ein: ");
    string zweiteZahl = Console.ReadLine();
    double zweiterzahlAlsInt = double.Parse(zweiteZahl);
    Console.WriteLine();
}



int kleineZahl = 1;
int großeZahle = 6;
Console.WriteLine(Math.Min(großeZahle,kleineZahl));


