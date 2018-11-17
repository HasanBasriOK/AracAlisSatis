using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracAlisSatis.Entity
{
    public class Araba
    {
        public int ArabaID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int VitesTuruID { get; set; }
        public int YakitTuruID { get; set; }
        public int RenkID { get; set; }
    }
}
