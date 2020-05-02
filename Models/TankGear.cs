using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoA_Site.Models
{
    public class TankGear
    {

        public TankGear(string ign)
        {
            this.ign = ign;
         
        }
        public string ign { get; set; }
        public Boolean Ebon { get; set; }
        public Boolean Alkosh { get; set; }
        public Boolean Yolna { get; set; }
        public Boolean Akaviri { get; set; }
        public Boolean Torug { get; set; }
        public Boolean Powerful_Assault { get; set; }
        public Boolean Morag_Tong { get; set; }
        public Boolean Worm { get; set; }
        public Boolean Hircine { get; set; }
        public Boolean Dragons_Defilement { get; set; }
        public Boolean Lord_Warden { get; set; }
        public Boolean Stonekeeper { get; set; }
        public Boolean Earthgore { get; set; }
        public Boolean Thurvokun { get; set; }
        public Boolean Symphony { get; set; }
    }
}
