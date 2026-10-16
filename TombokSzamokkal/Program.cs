using System.Data;

namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();
        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach (int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void OsszegzesTetele()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine($"A számok összege: {osszeg}");
        }
        static void MegszamlalasTetele()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine($"A negatív számok száma: {db}");
        }

        static void EldontesTetel()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömbben.");
            }
            else
            {
                Console.WriteLine("Nincs 0 a tömbben.");
            }
        }

        static void KeresesTetel()
        {
            int keresett = 0; //nézzük meg, hogy van-e benne nulla, és ha van, mondjuk meg hanyadik indexen
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A keresett szám az {i}. indexen található.");
            }
            else
            {
                Console.WriteLine("A keresett szám nincs a tömbben.");
            }
        }

        static void Kivalasztas()
        {
            //tudjuk, hogy a keresett elem a tömbben van, és megmondjuk hanyadik indexen.
            tomb[8] = 10; // például
            int i = 0;
            while (tomb[i] != 10)
            {
                i++;
            }
            Console.WriteLine($"A keresett szám az {i + 1}. helyen található.");
        }
        static void Main(string[] args)
        {
            Feltolt();
            OsszegzesTetele();
            MegszamlalasTetele();
            EldontesTetel();
            KeresesTetel();
            Kivalasztas();
        }
    }
}
