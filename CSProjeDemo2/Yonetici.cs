using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Yonetici : Personel
    {
        public Yonetici() { }
        public Yonetici(string name, string title, int calismaSaati, int saatlikUcret, decimal bonus) : base(name, title, calismaSaati, saatlikUcret)
        {
            this.bonus = bonus;
        }
        public decimal bonus { get; set; }


        public override BordrdoDto MaasHesapla()
        {
            BordrdoDto bordo = new();

            if (saatlikUcret < 500)
            {
                throw new Exception("Yoneticinin saatlik ücreti 500tl'den düşük olamazç");
            }
            else
            {
                bordo.PersonelIsmi = name;
                bordo.CalismaSaati = calismaSaati;
                bordo.AnaOdeme = saatlikUcret * calismaSaati + bonus;
                if (calismaSaati < 180) bordo.Mesai = 0;
                else bordo.Mesai = (calismaSaati - 180) * saatlikUcret;
                bordo.ToplamOdeme = bordo.Mesai + bordo.AnaOdeme;

                return bordo;
            }
        }

    }
}
