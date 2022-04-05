
Netzteil Gerät1 = new Netzteil("192.168.0.44", 8, "Keysight", 5);
Gerät1.Infos();
Gerät1.Reset();
Gerät1.DisplayText();
Gerät1.Voltage();


Console.WriteLine();
Console.WriteLine();


Messgerät Gerät2 = new Messgerät("192.168.0.30", 5, "Voltcraft", 2);
Gerät2.Infos();
Gerät2.Reset();
Gerät2.DisplayText();
Gerät2.Gemessenespannung();
