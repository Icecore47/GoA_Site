using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoA_Site.Models
{
    [FirestoreData]
    public class HealerGear
    {
        public HealerGear()
        {
        }

        public HealerGear(string ign)
        {
            this.ign = ign;
        }

        [FirestoreProperty] public Boolean Olorime { get; set; }
        [FirestoreProperty] public Boolean Torug { get; set; }
        [FirestoreProperty] public Boolean Infallible_Mage { get; set; }
        [FirestoreProperty] public Boolean Jorvulds { get; set; }
        [FirestoreProperty] public Boolean Zens { get; set; }
        [FirestoreProperty] public Boolean Martial_Knowledge { get; set; }
        [FirestoreProperty] public Boolean Hollowfang { get; set; }
        [FirestoreProperty] public Boolean Worm { get; set; }
        [FirestoreProperty] public Boolean Sanctuary { get; set; }
        [FirestoreProperty] public Boolean Mending { get; set; }
        [FirestoreProperty] public Boolean Sentinel { get; set; }
        [FirestoreProperty] public Boolean Symphony { get; set; }
        [FirestoreProperty] public Boolean NightFlame { get; set; }
        [FirestoreProperty] public Boolean TrollKing { get; set; }
        [FirestoreProperty] public Boolean EarthGore { get; set; }
        [FirestoreProperty] public Boolean Master_Staff { get; set; }
        [FirestoreProperty] public Boolean Black_Rose_Staff { get; set; }
        [FirestoreProperty] public Boolean Asylum_Staff{ get; set; }
        [FirestoreProperty]  public string ign { get; internal set; }
    }
}
