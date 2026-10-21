namespace Classes_cvicenia;

class Program
{
    static void Main(string[] args)
    {
        Hrdina Hrdina1 = new Hrdina();
        Hrdina1.meno = "Ironman";
        Hrdina1.zdravie = 50;
        Hrdina1.energia = 150;

        Hrdina Hrdina2 = new Hrdina();
        Hrdina2.meno = "batman";
        Hrdina2.zdravie = 45;
        Hrdina2.energia = 100;


        int silaUtoku = 20;
        while (Hrdina1.zdravie>0 && Hrdina2.zdravie>0)
        {
            
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
}
