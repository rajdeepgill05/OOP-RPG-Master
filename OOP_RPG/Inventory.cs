using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Inventory
    {
        public string Name { get; set; }
        public int OriginalValue { get; set; }
        public int ID { get; set; }

        public Inventory(string name, int originalValue, int id)
        {
            this.Name = name;
            this.OriginalValue = originalValue;
            this.ID = id;
        }
    }
    
}
