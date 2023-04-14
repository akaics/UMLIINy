using System;
using UMLIINy;
using static System.Formats.Asn1.AsnWriter;

namespace UML2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Test();
            Console.Write("Tryk på en knap for at starte user dialog");
            Console.ReadKey();
            store.Run();
        }
    }
}