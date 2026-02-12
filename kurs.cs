using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class Kurs
{
    public int kode { get; set; }
    public string navn { get; set; }
    public int studiepoeng { get; set; }

    public int antallPlasser { get; set; }


    public void meldPaa(student s)
    {
        if (antallPlasser > 0)
        {
            s.kurs.Add(this);
            antallPlasser--;
        }
    }   

    public void oprettKurs(string navn, int kode, int studiepoeng, int antallPlasser)
    {
        this.navn = navn;
        this.kode = kode;
        this.studiepoeng = studiepoeng;
        this.antallPlasser = antallPlasser;
    }


    public void meldAv(student s)
    {
        if (s.kurs.Contains(this))
        {
            s.kurs.Remove(this);
            antallPlasser++;
        }
    }

    public void visInfo()
    {
        Console.WriteLine($"Kode: {antallPlasser}, Navn: {navn}");
    }





}