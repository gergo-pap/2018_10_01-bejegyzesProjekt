using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    public class Bejegyzés
    {
        string szerzo;
        string tartalom;
        int likeok;
        DateTime letrejott = DateTime.Now;
        DateTime szerkeztve = DateTime.Now;

        public string Szerzo
        {
            get
            {
                return szerzo;
            }


        }

        public string Tartalom
        {
            get
            {
                return tartalom;
            }

            set
            {
                tartalom = value;
            }
        }

        public int Likeok
        {
            get
            {
                return likeok;
            }

        }

        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }

        }

        public DateTime Szerkeztve
        {
            get
            {
                return szerkeztve;
            }

        }

        public Bejegyzés (string szerzo, string tartalom) {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
        }
        
        public void Like() {
            this.likeok++;
        }

        public string Kiir() {
            //Console.WriteLine("{0} - {1} - {2}", this.szerzo, this.likeok, this.letrejott);
            //Console.WriteLine("Szerkeztve: {0}", this.szerkeztve);
            //Console.WriteLine("{0}", this.tartalom);
            string valasz = this.szerzo + " - " + this.likeok + " - " + this.letrejott + "\nSzerkeztve: " + this.szerkeztve + "\n" + this.tartalom;
            return valasz;
        }

    }
        


}