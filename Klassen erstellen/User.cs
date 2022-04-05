
public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }

    public User(string user, string pw)
    {
        UserName = user;
        Password = pw;
    }

    public bool Login()
    {
        //Datenbankenabrage richtig krass

        if (UserName == "Adel" && Password =="Nasenspray")
        {
            Console.WriteLine("Juhuuu, du bist eingelogt");
            return true;
        }
        else
        {
            Console.WriteLine("Falsch falsch falsch");
            return false;
        }
    }
}

