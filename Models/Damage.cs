using Google.Cloud.Firestore;
using System;

namespace GoA_Site.Models
{
    [FirestoreData]
    public class Damage
    {
        public Damage()
        {
        }

        public Damage(string inGameName, string characterName, double dPS, string type, string @class, string parse)
        {
            InGameName = inGameName;
            CharacterName = characterName;
            DPS = dPS;
            Type = type;
            Class = @class;
            Parse = parse;
        }
        [FirestoreProperty]
        public String InGameName { get; set; }
        [FirestoreProperty]
        public String CharacterName { get; set; }
        [FirestoreProperty]
        public Double DPS { get; set; }
        [FirestoreProperty]
        public String Type { get; set; }
        [FirestoreProperty]
        public String Class { get; set; }
        [FirestoreProperty]
        public String Parse { get; set; }
    }
}