

public class Utvekslingsstudent : Student{

public string hjemland { get; set; }

public string hjemmeuniversitet { get; set; }

public string startdato { get; set; }

public string sluttdato { get; set; }

public Utvekslingsstudent(int id, string fornavn, string epost, string hjemland, string hjemmeuniversitet, string startdato, string sluttdato)
    : base(id, fornavn, epost)
{
    this.hjemland = hjemland;
    this.hjemmeuniversitet = hjemmeuniversitet;
    this.startdato = startdato;
    this.sluttdato = sluttdato;
}



}