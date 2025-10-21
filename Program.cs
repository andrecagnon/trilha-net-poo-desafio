using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Smartphone Nokia ");
            Smartphone nokia = new Nokia("123456789", "Nokia 3310", "111111111111111", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n Smartphone iPhone ");
            Smartphone iphone = new Iphone("987654321", "iPhone 14 Pro", "222222222222222", 256);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}