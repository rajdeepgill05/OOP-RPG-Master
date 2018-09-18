using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Potion : Item
    {
        // properties 
        public int HP { get; set; }
        public string Name { get; set; }
        public int OriginalValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ResellValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        // Constructor
        public  Potion (int hp , string name)
        {
            this.HP = hp;
            this.Name = name;
            
        }
    }
}
