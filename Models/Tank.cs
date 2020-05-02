using Google.Cloud.Firestore;
using System;

namespace GoA_Site.Models
{
    [FirestoreData]
    public class Tank
    {
        public Tank()
        {
        }

        public Tank(string inGameName, string characterName, string @class)
        {
            InGameName = inGameName;
            CharacterName = characterName;
            Class = @class;
        }
        [FirestoreProperty]
        public String InGameName { get; set; }
        [FirestoreProperty]
        public String CharacterName { get; set; }
        [FirestoreProperty]
        public String Class { get; set; }
    }
}