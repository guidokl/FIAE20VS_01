using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE01_BruchGUI
{
    class Bruch
    {
        int zaehler;
        int nenner;

        public int GetZaehler()
        {
            return zaehler;
        }
        public int GetNenner()
        {
            return nenner;
        }
        public void SetZaehler(int zaehler)
        {
            this.zaehler = zaehler;
        }

        public Bruch(int iZaehler, int iNenner)
        {
            zaehler = iZaehler;
            nenner = iNenner;
        }

        public string GetConsoleString()
        {
            string sErg = "z:" + zaehler + " n:" + nenner;
            return sErg;
        }

        public Bruch Mult(Bruch b)
        {
            int iErgZaehler = zaehler * b.zaehler;
            int iErgNenner = nenner * b.nenner;

            Bruch bErg = new Bruch(iErgZaehler, iErgNenner);

            return bErg;
        }
        public Bruch Div(Bruch b)
        {
            int iErgZaehler = zaehler * b.nenner;
            int iErgNenner = nenner * b.zaehler;

            Bruch bErg = new Bruch(iErgZaehler, iErgNenner);

            return bErg;
        }

        public Bruch Add(Bruch b)
        {
            int iErgZaehler = (zaehler * b.nenner) + b.zaehler * nenner;
            int iErgNenner = nenner * b.nenner;

            Bruch bErg = new Bruch(iErgZaehler, iErgNenner);

            return bErg;
        }

        public Bruch Sub(Bruch b)
        {
            int iErgZaehler = (zaehler * b.nenner) - b.zaehler * nenner;
            int iErgNenner = nenner * b.nenner;

            Bruch bErg = new Bruch(iErgZaehler, iErgNenner);

            return bErg;
        }

        public Bruch Kuerzen()
        {
            int ggt = GCD(zaehler, nenner);
            Bruch bErg = new Bruch(zaehler / ggt, nenner / ggt);
            return bErg;
        }


        int GCD(int a, int b)
        {
            while (b > 0)
            {
                int rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }

        override
        public string ToString()
        {
            string sErg = zaehler + "/" + nenner;
            return sErg;
        }
    }
}
