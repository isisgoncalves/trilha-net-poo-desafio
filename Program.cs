using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia(numero: "123456789");
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone IPhone: ");
        Smartphone iphone = new Iphone(numero: "987654321");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}
