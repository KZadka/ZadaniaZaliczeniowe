namespace ZadaniaZaliczeniowe;

class Program
{
    static void Main(string[] args)
    {
        Osoba osoba1 = new Osoba("Jan Kowalski");
        Console.WriteLine(osoba1.Imię); 
        Console.WriteLine(osoba1.Nazwisko); 
        Console.WriteLine(osoba1.ImięNazwisko); 
        Console.WriteLine(osoba1.DataUrodzenia); 
        Console.WriteLine(osoba1.DataŚmierci); 
        osoba1.DataUrodzenia = new DateTime(1989, 1, 25);
        int age = (int)(osoba1.Wiek.Value.TotalDays / 365.25);
        Console.WriteLine(age);
    }
}
