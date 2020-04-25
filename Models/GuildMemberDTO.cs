using Google.Cloud.Firestore;
using Google.Type;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace GoA_Site.Models
{
    [FirestoreData]
    public class GuildMemberDTO
    {

        public GuildMemberDTO()
        { }

        public GuildMemberDTO(GuildMember g)
        {
            InGameName = g.InGameName;

            Events_Joined = g.Events_Joined;
            if (g.LastActive == null){ LastActive = 0; } else { LastActive = g.LastActive.Ticks;  }
           
            Guild_Rank = g.Guild_Rank;
            DD_Rank = g.DD_Rank;
            Healer_Rank = g.Healer_Rank;
            Tank_Rank = g.Tank_Rank;
            Discord_ID = g.Discord_ID;
            Discord_Name = g.Discord_Name;
            JoinDate = g.JoinDate.Ticks;
        }

        [FirestoreProperty]
        public String InGameName { get; set; }
        [FirestoreProperty]
        public int Events_Joined { get; set; }
        [FirestoreProperty]
        public long LastActive { get; set; }
        [FirestoreProperty]
        public String Guild_Rank { get; set; }
        [FirestoreProperty]
        public String DD_Rank { get; set; }
        [FirestoreProperty]
        public String Healer_Rank { get; set; }
        [FirestoreProperty]
        public String Tank_Rank { get; set; }
        [FirestoreProperty]
        public string Discord_ID { get; set; }
        [FirestoreProperty]
        public string Discord_Name { get; set; }
        [FirestoreProperty]
        public long JoinDate { get; set; }




    }
}
