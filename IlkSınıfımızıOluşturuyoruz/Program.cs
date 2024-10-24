class Program
{
    static void Main(string[] args)
    {
        // Öğrenci nesneleri oluşturma
        Person ogrenci1 = new Person("Ali", "Yılmaz", new DateTime(2010, 5, 15));
        Person ogrenci2 = new Person("Ayşe", "Kara", new DateTime(2011, 8, 22));

        // Öğretmen nesneleri oluşturma
        Person ogretmen1 = new Person("Mehmet", "Demir", new DateTime(1985, 3, 30));
        Person ogretmen2 = new Person("Fatma", "Aydın", new DateTime(1990, 12, 1));

        // Bilgileri konsola yazdırma
        Console.WriteLine("Öğrenciler:");
        ogrenci1.BilgileriYazdir();
        ogrenci2.BilgileriYazdir();

        Console.WriteLine("\nÖğretmenler:");
        ogretmen1.BilgileriYazdir();
        ogretmen2.BilgileriYazdir();
    }
}
