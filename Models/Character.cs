using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Range(1, 20)]
        public int Level { get; set; }
        public int RolledHP { get; set; }

        [Range(1, 20)]
        [Display(Name = "Strength")]
        public int Str { get; set; }

        [Range(1, 20)]
        [Display(Name = "Constitution")]
        public int Con { get; set; }

        [Range(1, 20)]
        [Display(Name = "Dexterity")]
        public int Dex { get; set; }

        [Range(1, 20)]
        [Display(Name = "Intelligence")]
        public int Int { get; set; } //Intelligence 

        [Range(1, 20)]
        [Display(Name = "Wisdom")]
        public int Wis { get; set; }

        [Range(1, 20)]
        [Display(Name = "Charisma")]
        public int Cha { get; set; }


    }

    public enum Class
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Warlock,
        Wizard
    }

    public enum Race
    {
        Dragonborn,
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        HalfOrc,
        Human,
        Tiefling
    }
}
