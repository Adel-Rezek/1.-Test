
public class Netzteil : Hardware
{
    public double SetSpannung { get; set; }

    public Netzteil(string ip, double port, string name, double setspannung) : base(ip, port, name)
    {
        SetSpannung = setspannung;
    }
    public void Voltage()
    {
        Console.WriteLine($"nach dem einschalten soll die Spannung auf {SetSpannung} eingestellt");
    }
}
