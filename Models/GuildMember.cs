using Google.Cloud.Firestore;
using Google.Type;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoA_Site.Models
{
    [FirestoreData]
    public class GuildMember
    {

        public GuildMember()
        {}
        public GuildMember(string inGameName, string guild_Rank,  string discord_ID, string discord_Name, DateTime joinDate)
        {
            InGameName = inGameName;

            Events_Joined = 0;
            LastActive = DateTime.Now; 
            Guild_Rank = guild_Rank;
            DD_Rank = "None";
            Healer_Rank = "None";
            Tank_Rank = "None";
            Discord_ID = discord_ID;
            Discord_Name = discord_Name;
            JoinDate = joinDate;
        }

        public GuildMember(GuildMemberDTO g)
        {
            InGameName = g.InGameName;
  
            Events_Joined = g.Events_Joined;
            LastActive = new DateTime(g.LastActive);
            Guild_Rank = g.Guild_Rank;
            DD_Rank = g.DD_Rank;
            Healer_Rank = g.Healer_Rank;
            Tank_Rank = g.Tank_Rank;
            Discord_ID = g.Discord_ID;
            Discord_Name = g.Discord_Name;
            JoinDate = new DateTime(g.JoinDate);
        }

        [FirestoreProperty]
        public String InGameName { get;  set; }
        [FirestoreProperty]
        public int Events_Joined { get; set; }
        [FirestoreProperty]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastActive { get; set; }
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JoinDate { get; set; }




    }
}
