namespace Classes_cvicenia;

class Program
{
    static void Main(string[] args)
    {
       /*Hrdina Hrdina1 = new Hrdina();
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
        }*/

       Ucet Ucet1 = new Ucet();
       Ucet Ucet2 = new Ucet();

       Ucet1.cislo = "SK12345789";
       Ucet1.majitel = "Ivo";
       Ucet1.zostatok = 200;

       Ucet2.cislo = "SK93189391384";
       Ucet2.majitel = "Vajo";
       Ucet2.zostatok = 500;

       Ucet1.VlozPeniaze(100);
       Console.WriteLine($"Vlozil si 100 tvoj stav uctu je {Ucet1.zostatok}");

       Ucet1.VyberPeniaze(100);
       Console.WriteLine($"Vybral si 100 tvoj stav uctu je {Ucet1.zostatok}");
       
       Ucet2.VlozPeniaze(200);
       Console.WriteLine($"Vlozil si 200 tvoj stav uctu je {Ucet2.zostatok}");

       Ucet2.VyberPeniaze(100);
       Console.WriteLine($"Vybral si 100 tvoj stav uctu je {Ucet2.zostatok}");
       
       Ucet1.VlozPeniaze(-100);
       Console.WriteLine($"Vlozil si -100 tvoj stav uctu je {Ucet1.zostatok}");
       
       Ucet2.VyberPeniaze(1000);
       Console.WriteLine($"Vybral si 1000 tvoj stav uctu je {Ucet2.zostatok}");
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


class Ucet
{
    public string cislo = "";
    public string majitel = "";
    public decimal zostatok = 0;

    public decimal VlozPeniaze(decimal suma)
    {
        if (suma < 0)
        {
            Console.WriteLine("nemozes vlozit zapornu sumu");
            return zostatok;
        }
        else
        {
            zostatok= zostatok + suma;
            return zostatok;

        }
    }
    public bool VyberPeniaze(decimal suma)
    {
        if (suma < 0)
        {
            Console.WriteLine("Suma musi byt kladna");
            return false;
        }

        if (zostatok >= suma)
        {
            zostatok = zostatok - suma;
            return true;
        }
        else
        {
            Console.WriteLine("Nemas dostatok penati na ucte");
            return false;
        }
    }
}
