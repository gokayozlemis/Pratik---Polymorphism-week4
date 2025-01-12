using System;

// base class: 
abstract class BaseGeometrikSekil
{
    // ortak property'ler
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }
    // alan hesaplama metodu
    public abstract double AlanHesapla();
}
// kare sınıfı
class Kare : BaseGeometrikSekil
{
    public override double AlanHesapla()
    {
        return Genislik * Yukseklik; 
    }
}
// dikdörtgen sınıfı
class Dikdortgen : BaseGeometrikSekil
{
    // alan hesaplama metodunun override'ı
    public override double AlanHesapla()
    {
        return Genislik * Yukseklik; 
    }
}
// Dik Üçgen sınıfı
class DikUcgen : BaseGeometrikSekil
{
    // alan hesaplama metodunun override'ı
    public override double AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2; 
    }
}
class Program
{
    static void Main(string[] args)
    {
        BaseGeometrikSekil kare = new Kare() { Genislik = 45 , Yukseklik = 56 };
        Console.WriteLine($"Kare'nin Alanı: {kare.AlanHesapla()}");

        BaseGeometrikSekil dikdortgen = new Dikdortgen() { Genislik = 78, Yukseklik = 12 };
        Console.WriteLine($"Dikdörtgen'in Alanı: {dikdortgen.AlanHesapla()}");

        BaseGeometrikSekil dikUcgen = new DikUcgen() { Genislik = 48, Yukseklik = 86 };
        Console.WriteLine($"Dik Üçgen'in Alanı: {dikUcgen.AlanHesapla()}");

        Console.ReadLine();
    }
}