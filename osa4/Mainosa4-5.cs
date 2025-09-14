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
            Console.OutputEncoding = Encoding.UTF8;
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

            Funkosa5.pealinnad_maakonnad();
        }
    }
}
