using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osa4
{
    internal class Funkosa5
    {
        public static void kogumine()
        {
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }

        public static List<Toode> LooToodeteNimekiri()
        {
            return new List<Toode>
        {
            new Toode("Õun", 52),
            new Toode("Leib", 265),
            new Toode("Kanafilee", 165)
        };
        }

        public static Inimene LoeKasutajaAndmed()
        {
            Console.Write("Sugu (mees/naine): ");
            string sugu = Console.ReadLine();

            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            Console.Write("Pikkus (cm): ");
            double pikkus = double.Parse(Console.ReadLine());

            Console.Write("Kaal (kg): ");
            double kaal = double.Parse(Console.ReadLine());

            Console.Write("Aktiivsus (1-5): ");
            int aktiivsus = int.Parse(Console.ReadLine());

            return new Inimene(sugu, vanus, pikkus, kaal, aktiivsus);
        }

        public static void KuvadaTulemused(Inimene inimene, double energiavajadus, List<Toode> tooted)
        {
            Console.WriteLine($"{inimene.Sugu} energiavajadus: {energiavajadus:F0} kcal");
            Console.WriteLine("Soovitatav kogus grammi iga toote kohta:");

            foreach (var t in tooted)
            {
                double grammid = energiavajadus / t.Kalorid100g * 100;
                Console.WriteLine($"{t.Nimi}: {grammid:F1} g");
            }
        }




    }
}
