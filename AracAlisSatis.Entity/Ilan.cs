using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracAlisSatis.Entity
{
    public class Ilan
    {
        public int IlanID { get; set; }
        public string Ilan_Adi { get; set; }
        public double Ilan_Fiyat { get; set; }
        public double Ilan_Km { get; set; }
        public DateTime Ilan_Tarih { get; set; }
        public int Ilan_ArabaID { get; set; }
        public int Ilan_SehirID { get; set; }
    }
}
