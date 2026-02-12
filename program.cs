using Universitetssystem;

List<Kurs> kursListe = new List<Kurs>();
List<Student> studentListe = new List<Student>();
List<Bibliotek> bokListe = new List<Bibliotek>
{
    new Bibliotek(1, "Harry Potter og de vises stein", "J.K. Rowling", 1997, 5),
    new Bibliotek(2, "Ringenes Herre: Ringens Brorskap", "J.R.R. Tolkien", 1954, 3),
    new Bibliotek(3, "To Kill a Mockingbird", "Harper Lee", 1960, 4),
    new Bibliotek(4, "1984", "George Orwell", 1949, 2),
    new Bibliotek(5, "The Great Gatsby", "F. Scott Fitzgerald", 1925, 6)
};

while (true)
{
    Console.WriteLine("Velkommen til universitetet!");
    Console.WriteLine("1. Opprett kurs");
    Console.WriteLine("2. Meld på student til kurs");
    Console.WriteLine("3. Søk etter kurs");
    Console.WriteLine("4. Vis kursinfo");
    Console.WriteLine("5. Søk på bok");
    Console.WriteLine("6. Lån ut bok");
    Console.WriteLine("7. Returner bok");
    Console.WriteLine("8. Legg til bok");
    Console.WriteLine("9. Avslutt");
    Console.Write("Velg et alternativ (1-9): ");
    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Opprett kurs");
            Console.Write("Skriv inn kursnavn: ");
            string? navn = Console.ReadLine();
            Console.Write("Skriv inn kurskode: ");
            int kode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv inn studiepoeng: ");
            int studiepoeng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv inn antall plasser: ");
            int antallPlasser = Convert.ToInt32(Console.ReadLine());

            Kurs nyttKurs = new Kurs();
            nyttKurs.oprettKurs(navn, kode, studiepoeng, antallPlasser);
            kursListe.Add(nyttKurs);
            break;
        case "2":
            Console.WriteLine("Meld på student til kurs");
            Console.Write("Skriv inn studentens fornavn: ");
            string? fornavn = Console.ReadLine();
            Console.Write("Skriv inn studentens epost: ");
            string? epost = Console.ReadLine();
            Console.Write("Skriv inn studentens id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Student student1 = new Student(id, fornavn, epost);
            studentListe.Add(student1);

            Console.Write("Hvilket kurs vil du melde studenten på? (kurskode): ");
            int kursKode = Convert.ToInt32(Console.ReadLine());
            Kurs? paameldingsKurs = kursListe.FirstOrDefault(k => k.kode == kursKode);
            if (paameldingsKurs != null)
            {
                paameldingsKurs.meldPaa(student1);
                Console.WriteLine("Student meldt på kurset.");
            }
            else
            {
                Console.WriteLine("Fant ikke kurset.");
            }
            break;
        case "3":
            Console.WriteLine("Søk etter kurs");
            Console.Write("Skriv inn kursnavn: ");
            string? søkNavn = Console.ReadLine();
            var filterkurs = kursListe.Where(k => k.navn != null && k.navn.Contains(søkNavn ?? ""));
            foreach (var kurs in filterkurs)
            {
                Console.WriteLine($"Funnet kurs: {kurs.navn} med kode {kurs.kode}");
            }
            break;
        case "4":
            Console.WriteLine("Hvilket kurs vil du se info om? - vennligst bruk kursets navn for å søke");
            string? kursnavn = Console.ReadLine();
            Kurs? valgtKurs = kursListe.FirstOrDefault(k => k.navn?.Equals(kursnavn, StringComparison.OrdinalIgnoreCase) ?? false);
            if (valgtKurs != null)
            {
                Console.WriteLine("Vis kursinfo");
                valgtKurs.visInfo();
            }
            else
            {
                Console.WriteLine("Kurset ble ikke funnet");
            }
            break;
        case "5":
            Console.WriteLine("Søk etter bok");
            Console.Write("Skriv inn boktittel: ");
            string? søkTittel = Console.ReadLine();
            var filterbok = from bok in bokListe
                            where bok.tittel.Contains(søkTittel ?? "")
                            select bok;
            foreach (var bok in filterbok)
            {
                Console.WriteLine($"Funnet bok: {bok.tittel} av {bok.forfatter} utgitt i {bok.utgivelsesår} med {bok.antalleksemplarer} eksemplarer tilgjengelig.");
            }
            break;
        case "6":
            Console.WriteLine("Lån ut bok");
            Console.Write("Skriv inn tittel på boken du vil låne: ");
            string? lånTittel = Console.ReadLine();
            Bibliotek? lånebok = bokListe.FirstOrDefault(b => b.tittel.Equals(lånTittel, StringComparison.OrdinalIgnoreCase));
            if (lånebok != null)
            {
                lånebok.LånUt();
            }
            else
            {
                Console.WriteLine("Fant ikke boken i biblioteket.");
            }
            break;
        case "7":
            Console.WriteLine("Returner bok");
            Console.Write("Skriv inn tittel på boken du vil returnere: ");
            string? returnerTittel = Console.ReadLine();
            Bibliotek? returnerbok = bokListe.FirstOrDefault(b => b.tittel.Equals(returnerTittel, StringComparison.OrdinalIgnoreCase));
            if (returnerbok != null)
            {
                returnerbok.Returner();
            }
            else
            {
                Console.WriteLine("Fant ikke boken i biblioteket.");
            }
            break;
        case "8":
            Console.WriteLine("Legg til bok");
            Console.Write("Skriv inn boktittel: ");
            string? leggTilTittel = Console.ReadLine();
            Console.Write("Skriv inn forfatter: ");
            string? leggTilForfatter = Console.ReadLine();
            Console.Write("Skriv inn utgivelsesår: ");
            int leggTilUtgivelsesår = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv inn antall eksemplarer: ");
            int leggTilAntallEksemplarer = Convert.ToInt32(Console.ReadLine());

            Bibliotek nyBok = new Bibliotek(bokListe.Count + 1, leggTilTittel, leggTilForfatter, leggTilUtgivelsesår, leggTilAntallEksemplarer);
            bokListe.Add(nyBok);
            Console.WriteLine($"Boken '{leggTilTittel}' av {leggTilForfatter} er lagt til i biblioteket.");
            break;
        case "9":
            Console.WriteLine("Avslutter programmet. Ha en fin dag!");
            return;
        default:
            Console.WriteLine("Ugyldig valg, vennligst velg et alternativ mellom 1 og 9.");
            break;
    }
}

public interface IUtlån
{
    void LånUt();
    void Returner();
}