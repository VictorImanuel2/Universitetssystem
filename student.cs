using System.Diagnostics.Contracts;

public class Student
{
    

    public int id { get; set; }
    public string fornavn { get; set; }
    public string epost { get; set; }

    public List<Kurs> kurs { get; set; }
}