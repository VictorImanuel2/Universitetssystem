using System.Diagnostics.Contracts;

public class Student
{
    

    public int id { get; set; }
    public string fornavn { get; set; }
    public string epost { get; set; }

    public List<Kurs> kurs { get; set; }

    public Student(int id, string fornavn, string epost)
    {
        this.id = id;
        this.fornavn = fornavn;
        this.epost = epost;
        this.kurs = new List<Kurs>();
    }
}