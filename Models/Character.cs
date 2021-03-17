using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterManager.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public int RolledHP { get; set; }
        public int Str { get; set; }
        public int Con { get; set; }
        public int Dex { get; set; }
        public int Int { get; set; } //Intelligence 
        public int Wis { get; set; }
        public int Cha { get; set; }

        public int TotalHP()
        {
            return (Level * Con) + RolledHP;
        }
    }
}
