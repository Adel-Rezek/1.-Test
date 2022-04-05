
public class Messgerät : Hardware
{
    public double Messung { get; set; }
    public Messgerät(string ip, double port, string name, double messung) : base(ip, port, name)
    {
        Messung = messung;
    }
    public void Gemessenespannung()
    {
        Console.WriteLine($"Die Gemessenespannung ist: {Messung}.");
    }

}

