using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {

        static void Main(string[] args)
        {
            Bejegyzés b = new Bejegyzés("Arany János", "tartalom");
            b.Like();
            Console.WriteLine(b.Kiir());
            //b.setTartalom(Console.ReadLine());

            List<Bejegyzés> Lista = new List<Bejegyzés>();

            Lista.Add(new Bejegyzés( "Petőfi Sánor", "ververververververs"));
            Lista.Add(new Bejegyzés("Vörösmarty Mihály", "vervsverevsevrevsevs"));
            Lista.Add(new Bejegyzés("Vörösmarty Mihály", "vervsverevsevrevsevs"));
            Lista.Add(new Bejegyzés("Vörösmarty Mihály", "vervsverevsevrevsevs"));
            Lista.Add(new Bejegyzés("Vörösmarty Mihály", "vervsverevsevrevsevs"));
            Lista.Add(new Bejegyzés("Vörösmarty Mihály", "vervsverevsevrevsevs"));
            Lista.Add(new Bejegyzés("Vörösmarty Mihály", "vervsverevsevrevsevs"));
            Console.WriteLine("Írd be hány bejegyzést szeretnél hozzáadni a lsitához!");
            int hanyszor = int.Parse(Console.ReadLine());
            for (int i = 0; i < hanyszor; i++)
            {
                Console.WriteLine("Írd be a szerzőt: ");
                string szerzo = Console.ReadLine();
                Console.WriteLine("Írd be a tartalmat: ");
                string tartalom = Console.ReadLine();
                Lista.Add(new Bejegyzés(szerzo, tartalom));
            }
            int num = 20 * Lista.Count;
            Random r = new Random();
            for (int i = 0; i < num; i++)
            {
                int ideiglenes = r.Next(0, Lista.Count);
                Lista[ideiglenes].Like();  
            }
            foreach (var elem in Lista)
            {
                Console.WriteLine(elem.Kiir());
            }

            //Console.WriteLine("Írd be a második bejegyzés új szerzőjét: ");
            //string ujSzerzo = Console.ReadLine();
            Console.WriteLine("Írd be a második bejegyzés új tartalmát: ");
            string ujTartalom = Console.ReadLine();
            Lista[1].Tartalom =  ujTartalom;
            //Lista[1].Szerzo = ujSzerzo;


            Console.Clear();
            foreach (var l in Lista)
            {
                Console.WriteLine(l.Kiir());
            }
            int max = 0;
            int keves = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].Likeok > max)
                {
                    max = Lista[i].Likeok;
                }
                if (Lista[i].Likeok < 15 )
                {
                    keves++;
                }
            }
            Console.WriteLine("Legtöbb Like: {0} ", max);
            if (max > 35)
            {
                Console.WriteLine("Van olyan bejegyzés amely több mint 35 likeot kapott");
            }
            else Console.WriteLine("Nincs olyan bejegyzés amely több mint 35 likeot kapott");

            Console.WriteLine("Ennyi bejegyzés van amely 15-nél kevesebb likeot kapott: {0}", keves);

           for (int j = 0; j < Lista.Count; j++)
            {
                for (int i = 0; i < Lista.Count - 1; i++)
                {
                    if (Lista[i].Likeok < Lista[i + 1].Likeok)
                    {
                        Bejegyzés csere = Lista[i];
                        Lista[i] = Lista[i + 1];
                        Lista[i + 1] = csere;
                    }
                }
            }
            foreach (var elemek in Lista)
            {
                Console.WriteLine(elemek.Kiir());
            }




            Console.ReadKey();
        }
    }
}
