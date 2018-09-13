using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        public Shop()
        {
            ArmorsBag = new List<Armor>();
            WeaponsBag = new List<WeaponsBag>();
            Potions = new List<Potions>();
        }
        public List<Armor> ArmorsBag { get; set; }
        public List<WeaponsBag> WeaponsBag { get; set; }
        public List<Potions> Potions { get; set; }
    }
}
