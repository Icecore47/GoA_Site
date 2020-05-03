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
        private string ign;
        private string rank;
        private DateTime date;

        public GuildMember()
        {}


        public GuildMember(GuildMember g ,List<Damage> d, List<Healer>h, List<Tank> t, TankGear tg)
        {
            InGameName = g.InGameName;
            Events_Joined = g.Events_Joined;
            LastActive = g.LastActive;
            Guild_Rank = g.Guild_Rank;
            DD_Rank = g.DD_Rank;
            Healer_Rank = g.Healer_Rank;
            Tank_Rank = g.Tank_Rank;
            Discord_ID = g.Discord_ID;
            Discord_Name = g.Discord_Name;
            JoinDate = g.JoinDate;
            this.TankGears = tg;
            this.Tank = t;
            this.Healers = h;
            this.DDs = d;
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

        public GuildMember(string ign, string rank, string discord_id, string discord_name, DateTime date)
        {
            this.ign = ign;
            this.rank = rank;
            Discord_ID = discord_id;
            Discord_Name = discord_name;
            this.date = date;
        }

        public TankGear TankGears { get; set; }
        public List<Healer> Healers { get; set; }
        public List<Tank> Tank { get; set; }
        public List<Damage> DDs { get; set; }
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
