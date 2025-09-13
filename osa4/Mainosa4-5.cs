using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace osa4
{
    internal class Mainosa4
    {
        public static void Main(string[] args)
        {
            //Funkosa4.Kirjuta_failisse();
            //Console.WriteLine("faili nimi: ");
            //string failinimi = Console.ReadLine();
            //Funkosa4.loemefaili(failinimi);

            //Console.WriteLine("faili nimi: ");
            //string failinimi2 = Console.ReadLine();
            //Funkosa4.RidadeLugemine(failinimi2);
            //Funkosa5.kogumine();

            //var tooted = Funkosa5.LooToodeteNimekiri();
            //var inimene = Funkosa5.LoeKasutajaAndmed();
            //double kcal = inimene.ArvutaEnergiavajadus();

            //Funkosa5.KuvadaTulemused(inimene, kcal, tooted);

            while (true)
            {
                Console.WriteLine("\n--- Maakonnad ja Pealinnad ---");
                Console.WriteLine("1. Näita kõiki");
                Console.WriteLine("2. Otsi pealinna maakonna järgi");
                Console.WriteLine("3. Lisa uus maakond ja pealinn");
                Console.WriteLine("4. Muuda pealinna");
                Console.WriteLine("5. Kustuta maakond");
                Console.WriteLine("6. Välju");
                Console.Write("Valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Funkosa5.NaitaKoiki();
                        break;
                    case "2":
                        Funkosa5.OtsiPealinn();
                        break;
                    case "3":
                        Funkosa5.LisaUus();
                        break;
                    case "4":
                        Funkosa5.MuudaPealinn();
                        break;
                    case "5":
                        Funkosa5.Kustuta();
                        break;
                    case "6":
                        Console.WriteLine("Head aega!");
                        return;
                    default:
                        Console.WriteLine("Tundmatu valik!");
                        break;
                }
            }
        }
    }
}
