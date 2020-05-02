using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using Google.Cloud.Firestore;

namespace GoA_Site.Models
{
    public class Fire
    {
        string path = AppDomain.CurrentDomain.BaseDirectory + @"goa-a5f0a.json";
        FirestoreDb FireDB;
        CollectionReference Guild_Members, Guild_Trials;
        CollectionReference Guild_DDs, Guild_Healers, Guild_Tanks;
        CollectionReference Guild_Tank_Gear, Guild_Healer_Gear;


        public Fire()
        {
            Environment.SetEnvironmentVariable("google_application_credentials", path);
            FireDB = FirestoreDb.Create("goa-a5f0a");
            Guild_Members = FireDB.Collection("Guild_Members");
            Guild_Trials = FireDB.Collection("Guild_Trials");
            Guild_DDs = FireDB.Collection("Guild_DDs");
            Guild_Healers = FireDB.Collection("Guild_Healers");
            Guild_Tanks = FireDB.Collection("Guild_Tanks");
            Guild_Healer_Gear = FireDB.Collection("Guild_Healer_Gear");
            Guild_Tank_Gear = FireDB.Collection("Guild_Tank_Gear");
        }


        // Member Fuctions
        public async Task AddNewGuildMember(GuildMemberDTO g)
        {

            await Guild_Members.Document(g.InGameName).SetAsync(g);
        }
        public async Task UpdateGuildMember(GuildMemberDTO g)
        {
            await Guild_Members.Document(g.InGameName).SetAsync(g);
        }
        public async Task<List<GuildMember>> GetGuildMembers()
        {
            Query q = Guild_Members;
            QuerySnapshot qs = await q.GetSnapshotAsync();
            List<GuildMember> Members = new List<GuildMember>();
            foreach (DocumentSnapshot ds in qs.Documents)
            {
                var TempObj = ds.ConvertTo<GuildMemberDTO>();
                var x = new GuildMember(TempObj);
                Members.Add(x);
            }

            var y = Members;
            return (Members);
        }
        public async Task<GuildMember> GetGuildMember(string ID)
        {
            DocumentReference df = Guild_Members.Document(ID);
            DocumentSnapshot ds = await df.GetSnapshotAsync();
            GuildMember ReturnObj = null;
            if (ds.Exists)
            {
                var TempObj = ds.ConvertTo<GuildMemberDTO>();
                ReturnObj = new GuildMember(TempObj);
            }

            return (ReturnObj);
        }
        public async Task DeleteGuildMember(string ID)
        {
            DocumentReference df = Guild_Members.Document(ID);
            await df.DeleteAsync();
        }



        // DD Fuctions
        public async Task AddNewDD(Damage d)
        {
            await Guild_DDs.Document(d.CharacterName).SetAsync(d);
        }
        public async Task UpdateDD(Damage d)
        {
            await Guild_DDs.Document(d.CharacterName).SetAsync(d);
        }
        public async Task<List<Damage>> GetGuildDDs()
        {
            Query q = Guild_DDs;
            QuerySnapshot qs = await q.GetSnapshotAsync();
            List<Damage> DDs = new List<Damage>();
            foreach (DocumentSnapshot ds in qs.Documents)
            {
                var TempObj = ds.ConvertTo<Damage>();
                DDs.Add(TempObj);
            }
            return (DDs);
        }
        public async Task<Damage> GetGuildDamage(string ID)
        {
            DocumentReference df = Guild_DDs.Document(ID);
            DocumentSnapshot ds = await df.GetSnapshotAsync();
            Damage TempObj = null;
            if (ds.Exists)
            {
                TempObj = ds.ConvertTo<Damage>();
            }

            return (TempObj);
        }
        public async Task DeleteGuildDamage(string ID)
        {
            DocumentReference df = Guild_DDs.Document(ID);
            await df.DeleteAsync();
        }

        // Healer Fuctions
        public async Task AddNewHealer(Healer d)
        {
            await Guild_Healers.Document(d.CharacterName).SetAsync(d);
        }
        public async Task UpdateHealer(Healer d)
        {
            await Guild_Healers.Document(d.CharacterName).SetAsync(d);
        }
        public async Task<List<Healer>> GetGuildHealers()
        {
            Query q = Guild_Healers;
            QuerySnapshot qs = await q.GetSnapshotAsync();
            List<Healer> Healers = new List<Healer>();
            foreach (DocumentSnapshot ds in qs.Documents)
            {
                var TempObj = ds.ConvertTo<Healer>();
                Healers.Add(TempObj);
            }
            return (Healers);
        }
        public async Task<Healer> GetGuildHealer(string ID)
        {
            DocumentReference df = Guild_Healers.Document(ID);
            DocumentSnapshot ds = await df.GetSnapshotAsync();
            Healer TempObj = null;
            if (ds.Exists)
            {
                TempObj = ds.ConvertTo<Healer>();
            }

            return (TempObj);
        }
        public async Task DeleteGuildHealer(string ID)
        {
            DocumentReference df = Guild_Healers.Document(ID);
            await df.DeleteAsync();
        }

        // Tank Fuctions
        public async Task AddNewTank(Tank d)
        {
            await Guild_Tanks.Document(d.CharacterName).SetAsync(d);
        }
        public async Task UpdateTank(Tank d)
        {
            await Guild_Tanks.Document(d.CharacterName).SetAsync(d);
        }
        public async Task<List<Tank>> GetGuildTanks()
        {
            Query q = Guild_Tanks;
            QuerySnapshot qs = await q.GetSnapshotAsync();
            List<Tank> Tanks = new List<Tank>();
            foreach (DocumentSnapshot ds in qs.Documents)
            {
                var TempObj = ds.ConvertTo<Tank>();
                Tanks.Add(TempObj);
            }
            return (Tanks);
        }
        public async Task<Tank> GetGuildTank(string ID)
        {
            DocumentReference df = Guild_Tanks.Document(ID);
            DocumentSnapshot ds = await df.GetSnapshotAsync();
            Tank TempObj = null;
            if (ds.Exists)
            {
                TempObj = ds.ConvertTo<Tank>();
            }

            return (TempObj);
        }
        public async Task DeleteGuildTank(string ID)
        {
            DocumentReference df = Guild_Tanks.Document(ID);
            await df.DeleteAsync();
        }

        // Tank Gear
        public async Task AddNewTankGear(TankGear d)
        {
            await Guild_Tank_Gear.Document(d.ign).SetAsync(d);
        }
        public async Task UpdateTankGear(TankGear d)
        {
            await Guild_Tank_Gear.Document(d.ign).SetAsync(d);
        }

        // Healer Gear
        public async Task AddNewHealerGear(HealerGear d)
        {
            await Guild_Healer_Gear.Document(d.ign).SetAsync(d);
        }
        public async Task UpdateHealerGear(HealerGear d)
        {
            await Guild_Healer_Gear.Document(d.ign).SetAsync(d);
        }



    }
}
