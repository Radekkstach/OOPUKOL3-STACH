using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUKOL3STACH
{
    internal class Auto
    {
        private string znacka;
        private double spotreba;
        private int ujetoCelkem;
        private DateTime okamzikRozjezdu;
        private TimeSpan dobaJizdyCelkem;
        private bool jede;

        public bool Jede
        {
            get
            {
                return jede;
            }
        }

        public Auto(string znacka, double spotreba, int ujetoCelkem) 
        {
        
            this.znacka = znacka;
            this.spotreba = spotreba;
            this.ujetoCelkem= ujetoCelkem;
            jede = false;
            

        
        }

        public int VratUjeteKm()
        {
            return ujetoCelkem;
        }

        public void Rozjezd()
        {
            if (jede == false)
            {
                okamzikRozjezdu = DateTime.Now;
                jede = true;
            }
        }

        public void Zastav(int ujeto)
        {
            if (jede == true)
            {
                jede = false;
                ujetoCelkem += ujeto;
                dobaJizdyCelkem = dobaJizdyCelkem + (DateTime.Now - okamzikRozjezdu);
            }
            
        }

        public double CelkovaSpotreba()
        {
            double celkovaspotreba;
            celkovaspotreba = ujetoCelkem * (spotreba/100);
            return celkovaspotreba;
        }

        public override string ToString()
        {
            return "Auto znacky " + znacka + "\nSe spotrebou na 100Km " + spotreba + "l \nMá nájezd " + ujetoCelkem + "km s celkovou spotrebou " + Math.Round(CelkovaSpotreba(),2) + "l \nCas posledni rozjezdu " + okamzikRozjezdu.ToString() + " s celkovou dobou jizdy " + Math.Round((dobaJizdyCelkem.TotalMinutes),1) + " minut, \nJede auto?" + Jede;

        }
    }
}
