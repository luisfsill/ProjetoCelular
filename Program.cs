using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Console.WriteLine("Testando o Nokia:");
        Smartphone nokia = new Nokia("987654321", "Nokia 3310", "222222222222222", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        // Testando a classe Iphone
        Console.WriteLine("Testando o iPhone:");
        Smartphone iphone = new Iphone("123456789", "iPhone 13", "111111111111111", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
