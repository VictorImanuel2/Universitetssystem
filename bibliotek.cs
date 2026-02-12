using System.Data;

public class Bibliotek : IUtlån
{
    public int id { get; set; }

    public string tittel { get; set; }
    public string forfatter { get; set; }

    public int utgivelsesår { get; set; }

    public int antalleksemplarer { get; set; }   

    public Bibliotek(int id, string tittel, string forfatter, int utgivelsesår, int antalleksemplarer)
    {
        this.id = id;
        this.tittel = tittel;
        this.forfatter = forfatter;
        this.utgivelsesår = utgivelsesår;
        this.antalleksemplarer = antalleksemplarer;
    }



    public void leggTilBok(string tittel, string forfatter, int utgivelsesår, int antalleksemplarer)
    {
        this.tittel = tittel;
        this.forfatter = forfatter;
        this.utgivelsesår = utgivelsesår;
        this.antalleksemplarer = antalleksemplarer;
    }

    public void LånUt()
    {
        if (antalleksemplarer > 0)
        {
            antalleksemplarer--;
            Console.WriteLine($"Du har lånt ut '{tittel}' av {forfatter}. Antall eksemplarer igjen: {antalleksemplarer}");
        }
        else
        {
            Console.WriteLine($"Beklager, '{tittel}' av {forfatter} er ikke tilgjengelig for utlån.");
        }
    }

    public void Returner()
    {
        antalleksemplarer++;
        Console.WriteLine($"Du har returnert '{tittel}' av {forfatter}. Antall eksemplarer tilgjengelig: {antalleksemplarer}");     
    }
}