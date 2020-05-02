using System;

namespace GoA_Site.Models
{
    public class Tank
    {
        private string ign;
        private string name;
        private string clas;

        public Tank(string ign, string name, string clas)
        {
            this.ign = ign;
            this.name = name;
            this.clas = clas;
        }

        public String InGameName { get; set; }
        public String CharacterName { get; set; }
        public String Class { get; set; }
    }
}