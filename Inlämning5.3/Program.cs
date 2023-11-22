using System;
namespace inläning5.__3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fråga = new string[] {"En stad som börjar på V?","En stad som börjar med K","En stad som börjar med J","En golf spelare" };
            string[] svar = new string[] {"Växjö","Kalmar","Jönköping","Rory McIlroy" };
            Console.WriteLine("Skriv ett tal mellan 1 och 4");
            int tal = int.Parse(Console.ReadLine());
            Console.WriteLine(fråga[tal-1]);
            Console.ReadLine();
            Console.WriteLine(svar[tal - 1]);
        }
    }
}
