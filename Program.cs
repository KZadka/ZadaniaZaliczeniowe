namespace ZadaniaZaliczeniowe;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 1:");
        Osoba osoba1 = new("Jan Kowalski");
        Console.WriteLine($"Imię: {osoba1.Imię}");
        Console.WriteLine($"Nazwisko: {osoba1.Nazwisko}");
        Console.WriteLine($"Imię i Nazwisko: {osoba1.ImięNazwisko}");
        osoba1.DataUrodzenia = new DateTime(1989, 1, 25);
        int age = (int)(osoba1.Wiek.Value.TotalDays / 365.25);
        Console.WriteLine($"Wiek: {age}\n");

        Console.WriteLine("Zadanie 2:");
        Prostokąt p1 = new(7, 12);
        double bokA = Prostokąt.ArkuszPapieru("A4").BokA;
        Console.WriteLine($"Bok A arkusza 'A4': {bokA.ToString("F")}");
        double bokB = Prostokąt.ArkuszPapieru("A4").BokB;
        Console.WriteLine($"Bok B arkusza 'A4': {bokB.ToString("F")}\n");

        Console.WriteLine("Zadanie 3:");
        Wektor w1 = new(3.0, 11.0, 4.0, 5.0, 2.0);
        Wektor w2 = new(9.0, 1.0, 8.0, 2.0, 7.0);
        Console.WriteLine("Wymiar w1: " + w1.Wymiar);
        Console.WriteLine("Wymiar w2: " + w2.Wymiar);
        double iloczyn = Wektor.IloczynSkalarny(w1, w2);
        Wektor suma = w1 + w2;
        Console.WriteLine($"Iloczyn skalarny wektorów wynosi: {iloczyn}");
        Console.WriteLine($"Wektor z dodawania wektorów w1 i w2 to: {suma}");
        Console.WriteLine($"Długość wektora w1 to: {w1.Długość.ToString("F")}"); 
        Console.WriteLine($"Długość wektora w2 to: {w2.Długość.ToString("F")}"); 
    }
}
