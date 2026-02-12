



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


    System.Console.WriteLine("Velkommen til universitetet!");
    System.Console.WriteLine("1. Opprett kurs");
    System.Console.WriteLine("2. Meld på student til kurs");
    System.Console.WriteLine("3. søk etter kurs");
    System.Console.WriteLine("4. Vis kursinfo");
    System.Console.WriteLine("5. søk på bok");
    System.Console.WriteLine("6. Lån ut bok");
    System.Console.WriteLine("7. Returner bok");
    System.Console.WriteLine("8. legg til bok");
    System.Console.WriteLine("9. Avslutt    ");
    System.Console.WriteLine("Velg et alternativ (1-9): ");
    string input = Console.ReadLine().ToLower();



    switch (input)
    {


        case 1:
            System.Console.WriteLine("Opprett kurs");
            System.Console.WriteLine("Skriv inn kursnavn: ");
            string navn = Console.ReadLine();
            System.Console.WriteLine("Skriv inn kurskode: ");
            int kode = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Skriv inn studiepoeng: ");
            int studiepoeng = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Skriv inn antall plasser: ");
            int antallPlasser = Convert.ToInt32(Console.ReadLine());

            kurs1.oprettKurs(navn, kode, studiepoeng, antallPlasser);
            kursListe.Add(kurs1);
            break;
        case 2: 
            System.Console.WriteLine("Meld på student til kurs");
            System.Console.WriteLine("Skriv inn studentens fornavn: ");
            string fornavn = Console.ReadLine();
            System.Console.WriteLine("Skriv inn studentens epost: ");
            string epost = Console.ReadLine();
            System.Console.WriteLine("Skriv inn studentens id: ");
            string id = Console.ReadLine();
            student student1 = new student(fornavn, epost, id);
            student1.kurs = new List<kurs>();

            kurs1.meldPaa(student1);
            System.Console.WriteLine("Student meldt på kurset.");
            break;
        case 3:
            System.Console.WriteLine("Søk etter kurs");
            System.Console.WriteLine("Skriv inn kursnavn: ");
            string søkNavn = Console.ReadLine();
            var filterkurs = from kurs in student1.kurs
                             where kurs.navn.Contains(søkNavn)
                             select kurs;
            foreach (var kurs in filterkurs)
            {
                System.Console.WriteLine($"Funnet kurs: {kurs.navn} med kode {kurs.kode}");

            }
        break;
        case 4:
        System.Console.WriteLine("hvilket kurs vil du se info om? - venligst bruk kurset sitt navn for å søke");
        string kursnavn = Console.ReadLine();
        if (kursListe.Contains(kursnavn))
        {   
            System.Console.WriteLine("Vis kursinfo");
                kursnavn.visInfo();
                break;
        }
        else
        {
            System.Console.WriteLine("Kurset ble ikke funnet");
        }
        break;
        case 5:
            System.Console.WriteLine("Søk etter bok");
            System.Console.WriteLine("Skriv inn boktittel: ");
            string søkTittel = Console.ReadLine();
            var filterbok = from bok in bokListe
                            where bok.tittel.Contains(søkTittel)
                            select bok;
            foreach (var bok in filterbok)
            {
                System.Console.WriteLine($"Funnet bok: {bok.tittel} av {bok.forfatter} utgitt i {bok.utgivelsesår} med {bok.antalleksemplarer} eksemplarer tilgjengelig.");

            }
        break;
        case 6:
            System.Console.WriteLine("Lån ut bok");
            System.Console.WriteLine("Skriv inn boktittel: ");
            string lånTittel = Console.ReadLine();
            System.Console.WriteLine("Skriv inn forfatter: ");
            string lånForfatter = Console.ReadLine();
            System.Console.WriteLine("Skriv inn utgivelsesår: ");
            int lånUtgivelsesår = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Skriv inn antall eksemplarer: ");
            int lånAntallEksemplarer = Convert.ToInt32(Console.ReadLine());

            Bibliotek lånebok = new Bibliotek(0, lånTittel, lånForfatter, lånUtgivelsesår, lånAntallEksemplarer);
            lånebok.LånUt();
            break;
        case 7:
            System.Console.WriteLine("Returner bok");
            System.Console.WriteLine("Skriv inn boktittel: ");
            string returnerTittel = Console.ReadLine();
            System.Console.WriteLine("Skriv inn forfatter: ");
            string returnerForfatter = Console.ReadLine();
            System.Console.WriteLine("Skriv inn utgivelsesår: ");
            int returnerUtgivelsesår = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Skriv inn antall eksemplarer: ");
            int returnerAntallEksemplarer = Convert.ToInt32(Console.ReadLine());

            Bibliotek returnerbok = new Bibliotek(0, returnerTittel, returnerForfatter, returnerUtgivelsesår, returnerAntallEksemplarer);
            returnerbok.Returner();
            break;
        case 8:

            System.Console.WriteLine("Legg til bok");
            System.Console.WriteLine("Skriv inn boktittel: ");
            string leggTilTittel = Console.ReadLine();
            System.Console.WriteLine("Skriv inn forfatter: ");
            string leggTilForfatter = Console.ReadLine();
            System.Console.WriteLine("Skriv inn utgivelsesår: ");
            int leggTilUtgivelsesår = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Skriv inn antall eksemplarer: ");
            int leggTilAntallEksemplarer = Convert.ToInt32(Console.ReadLine());

            Bibliotek nyBok = new Bibliotek(0, leggTilTittel, leggTilForfatter, leggTilUtgivelsesår, leggTilAntallEksemplarer);
            bokListe.Add(nyBok);
            System.Console.WriteLine($"Boken '{leggTilTittel}' av {leggTilForfatter} er lagt til i biblioteket.");
            break;
        case 9:
            System.Console.WriteLine("Avslutter programmet. Ha en fin dag!");
            return;
        default:
            System.Console.WriteLine("Ugyldig valg, vennligst velg et alternativ mellom 1 og 9.");
            break;  










    }
    









}










public interface IUtlån
{
    void LånUt();
    void Returner();
}


