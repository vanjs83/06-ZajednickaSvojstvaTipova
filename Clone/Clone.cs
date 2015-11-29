using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Osoba : ICloneable
    {
        public Osoba(string ime, int matičniBroj)
        {
            m_ime = ime;
            m_matičniBroj = matičniBroj;
        }

        public string m_ime;       // član referentnog tipa
        public int m_matičniBroj;  // član vrijednosnog tipa

        public override bool Equals(object obj) 
        {
            //  Preslikati implementaciju metode Equals iz EqualsRefTip1
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            Osoba drugi = (Osoba)obj;
            if (Osoba.Equals(this.m_ime, drugi.m_ime) == false)
                return false;
            return m_matičniBroj.Equals(drugi.m_matičniBroj);
       

          //  return true;
        }

        public override string ToString()
        {
            return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
        }

        object ICloneable.Clone()
        {
            return (object)Clone();
        }

        // tipski sigurna implementacija
        public Osoba Clone()
        {
            //  implementirati metodu tako da se metoda Main može izvesti bez problema
             Osoba temp=(Osoba) this.MemberwiseClone();
             return temp;
           // return null;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // dvije osobe
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            Debug.Assert(osobaA.Equals(osobaB));
            
            osobaB.m_ime = "Marko";
            //Debug.Assert(osobaA.Equals(osobaB) == false);
            
            // kloniramo
            osobaB = osobaA.Clone();
            Debug.Assert(osobaA.Equals(osobaB));

            osobaB.m_ime = "Pero";
            Debug.Assert(osobaA.Equals(osobaB) == false);

            Console.ReadLine();
        }
    }
}
