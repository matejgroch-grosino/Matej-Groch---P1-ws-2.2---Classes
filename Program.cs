namespace Classes_cvicenia;

class Program
{
    static void Main(string[] args)
    {
        Hrdina Hrdina1 = new Hrdina();
        Hrdina1.meno = "Ironman";
        Hrdina1.zdravie = 100;
        Hrdina1.energia = 100;

        Hrdina Hrdina2 = new Hrdina();
        Hrdina2.meno = "batman";
        Hrdina2.zdravie = 100;
        Hrdina2.energia = 100;


        Random randomiser = new Random();
        int silaUtoku1 = randomiser.Next(10,30);
        int silaUtoku2 = randomiser.Next(10, 30);
        while (!(Hrdina1.zdravie==0||Hrdina2.zdravie==0))
        {
            Hrdina1.regeneracia();
            Hrdina2.regeneracia();
            bool PodarilSaUtok = Hrdina1.Utok(silaUtoku1);
            if (PodarilSaUtok)
            {
                Hrdina2.PrijmiZranenie(silaUtoku1);
                Console.WriteLine(Hrdina1.meno+" trafil!");
                Console.WriteLine(Hrdina2.meno+" ma uz len "+Hrdina2.zdravie+" zdravia");
            }
            else
            {
                Console.WriteLine(Hrdina1.meno+" je unaveny!");
            }

            PodarilSaUtok = Hrdina2.Utok(silaUtoku2);
            if (PodarilSaUtok)
            {
                Hrdina1.PrijmiZranenie(silaUtoku2);
                Console.WriteLine(Hrdina2.meno+" trafil!");
                Console.WriteLine(Hrdina1.meno+" ma uz len "+Hrdina1.zdravie+" zdravia");
            }
            else
            {
                Console.WriteLine(Hrdina2.meno+" je unaveny!");
            }
        }

        if (Hrdina1.zdravie == 0 && Hrdina2.zdravie == 0)
        {
            Console.WriteLine("Remiza!");
        }
        else if (Hrdina1.zdravie == 0)
        {
            Console.WriteLine(Hrdina2.meno+" vyhral!");
        }
        else if (Hrdina2.zdravie == 0)
        {
            Console.WriteLine(Hrdina1.meno+" vyhral!");
        }
    }
}

class Hrdina
{
    public string meno = "";
    public int zdravie = 100;
    public int energia = 50;

    public void VypisAktualnyStav()
    {
        Console.WriteLine("Meno: "+meno);
        Console.WriteLine("zdravie: "+zdravie);
        Console.WriteLine("energia: "+energia);
    }
    
    public bool Utok(int cena_energia)
    {
        if (energia < cena_energia)
        {
            return false;
        }
        else
        {
            energia = energia - cena_energia;
            return true;
        }
            
    }

    public int PrijmiZranenie(int sila)
    {
        zdravie = zdravie - sila;
        if (sila > zdravie)
        {
            zdravie = 0;
        }

        return zdravie;
    }

    public void regeneracia()
    {
        energia = energia + 5;
    }
}
