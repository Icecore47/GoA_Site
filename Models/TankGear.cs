using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoA_Site.Models
{
    [FirestoreData]
    public class TankGear
    {
        public TankGear()
        {
        }
        public TankGear(string ign)
        {
            this.ign = ign;
         
        }
        [FirestoreProperty]
        public string ign { get; set; }
        [FirestoreProperty]
        public Boolean Ebon { get; set; }
        [FirestoreProperty]
        public Boolean Alkosh { get; set; }
        [FirestoreProperty]
        public Boolean Yolna { get; set; }
        [FirestoreProperty]
        public Boolean Akaviri { get; set; }
        [FirestoreProperty]
        public Boolean Torug { get; set; }
        [FirestoreProperty]
        public Boolean Powerful_Assault { get; set; }
        [FirestoreProperty]
        public Boolean Morag_Tong { get; set; }
        [FirestoreProperty]
        public Boolean Worm { get; set; }
        [FirestoreProperty]
        public Boolean Hircine { get; set; }
        [FirestoreProperty]
        public Boolean Dragons_Defilement { get; set; }
        [FirestoreProperty]
        public Boolean Lord_Warden { get; set; }
        [FirestoreProperty]
        public Boolean Stonekeeper { get; set; }
        [FirestoreProperty]
        public Boolean Earthgore { get; set; }
        [FirestoreProperty]
        public Boolean Thurvokun { get; set; }
        [FirestoreProperty]
        public Boolean Symphony { get; set; }
    
    }
}
