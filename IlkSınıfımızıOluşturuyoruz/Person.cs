using System;

public class Person
{
    // Properties (özellikler)
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    // Constructor (yapıcı metod)
    public Person(string ad, string soyad, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }

    // Method (metod)
    public void BilgileriYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
    }
}
