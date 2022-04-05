
public class Hardware
{
    public string IPAdresse { get; set; }
    public double Port { get; set; }
    public string Name { get; set; }

    public Hardware(string ip, double port, string name)
    {
        IPAdresse = ip;
        Port = port;
        Name = name;
       
    }
    public void Infos()
    {
        Console.WriteLine($"Das Gerät ist ein {Name} hat IP-Adresse {IPAdresse} und Port-Nummer {Port} ");
    }
    public void Reset()
    {
        Console.WriteLine($"Das Gerät {Name} wurde neugestartet");
    }
    public void DisplayText()
    {
        Console.WriteLine($"Auf Display von Gerät {Name} erscheint Wort (Hallo)");
    }

}


