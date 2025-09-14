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

        public static void pealinnad_maakonnad()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, string> maakonnad = new Dictionary<string, string>();
            maakonnad["Harjumaa"] = "Tallinn";
            maakonnad["Tartumaa"] = "Tartu";
            maakonnad["Parnumaa"] = "Parnu";
            maakonnad["Ida-Virumaa"] = "Johvi";


            while (true)
            {
                Console.WriteLine("Vali tegevus:");
                Console.WriteLine("1. Otsi maakonna järgi");
                Console.WriteLine("2. Otsi linna järgi");
                Console.WriteLine("3. Mäng");
                Console.WriteLine("4. Välju");

                string valik = Console.ReadLine().ToLower();

                if (valik == "1")
                {
                    Console.Write("Sisesta maakonna nimi: ");
                    string maakond = Console.ReadLine();

                    string leitudPealinn = null;
                    foreach (var paar in maakonnad)
                    {
                        if (paar.Key.ToLower() == maakond.ToLower())
                        {
                            leitudPealinn = paar.Value;
                            break;
                        }
                    }

                    if (leitudPealinn != null)
                    {
                        Console.WriteLine(maakond + "  on " + leitudPealinn);
                    }
                    else
                    {
                        Console.WriteLine("Maakonda ei leitud. Sisesta pealinna nimi, et lisada see sõnastikku:");
                        string pealinn = Console.ReadLine();
                        maakonnad[maakond] = pealinn;
                        Console.WriteLine("Maakond ja linn lisatud.");
                    }
                }
                else if (valik == "2")
                {
                    Console.Write("Sisesta linna nimi: ");
                    string pealinn = Console.ReadLine();

                    string leitudMaakond = "";
                    foreach (var paar in maakonnad)
                    {
                        if (paar.Value.ToLower() == pealinn.ToLower())
                        {
                            leitudMaakond = paar.Key;
                            break;
                        }
                    }

                    if (leitudMaakond != "")
                    {
                        Console.WriteLine(pealinn + " asub " + leitudMaakond + "l.");
                    }
                    else
                    {
                        Console.WriteLine("Linna ei leitud. Sisesta maakonna nimi, et lisada see sõnastikku:");
                        string uusMaakond = Console.ReadLine();
                        maakonnad[uusMaakond] = pealinn;
                        Console.WriteLine("Maakond ja linn lisatud.");
                    }
                }
                else if (valik == "3")
                {
                    int kokku = 0;
                    int oigeid = 0;
                    Random rnd = new Random();

                    // nimekiri maakondadest
                    List<string> allesJäänud = new List<string>(maakonnad.Keys);

                    while (allesJäänud.Count > 0)
                    {
                        // Vali juhuslik maakond, mida pole veel küsitud
                        int index = rnd.Next(allesJäänud.Count);
                        string maakond = allesJäänud[index];
                        string pealinn = maakonnad[maakond];

                        Console.WriteLine("Mis on " + maakond + " linn? (kirjuta 'valju' lõpetamiseks)");
                        string vastus = Console.ReadLine();

                        if (vastus.Trim().ToLower() == "valju")
                            break;

                        kokku++;

                        if (vastus.Trim().ToLower() == pealinn.ToLower())
                        {
                            Console.WriteLine("Õige!");
                            oigeid++;
                        }
                        else
                        {
                            Console.WriteLine("Vale! Õige vastus on " + pealinn);
                        }

                        // Eemaldame küsitud maakond, et ei korduks
                        allesJäänud.RemoveAt(index);
                    }

                    Console.WriteLine($"Kokku küsimusi: {kokku}, Õigeid vastuseid: {oigeid}");
                }

                else if (valik == "4")
                {
                    Console.WriteLine("Head aega!");
                    break;
                }
                else
                {
                    Console.WriteLine("Tundmatu valik.");
                }
            }
        }

    }
}

