using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        List<Armor> Armors { get; set; }
        List<Weapon> Weapons { get; set; }
        List<Potion> Potions { get; set; }
        
        public Game game { get; set; }
        public Armor armor { get; set; }
        public Weapon weapon { get; set; }
        public Potion potions { get; set; }
        

        public Shop(Game game)
        {
            this.game = game;

            this.Armors.Add(new Armor("WoodenArmor", 10, 2, 3));
            this.Armors.Add(new Armor("Metal Armor", 20, 5, 7));
            this.Weapons.Add(new Weapon("Sword", 10, 2, 3));
            this.Weapons.Add(new Weapon("Axe", 12, 3, 4));
            this.Weapons.Add(new Weapon("Longsword", 20, 5, 7));
            this.Potions.Add(new Potion(5, "Healing Potion"));



        }
        

        public void GetInventory(string name, int originalValue, int id)
        {
            
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("1. Buy Item");
            Console.WriteLine("2. Sell Item");
            Console.WriteLine("3. Return to game menu");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.ShowInventory();
            }
            else if (input == "2")
            {
                this.BuyFromUser();
            }
            else if (input == "3")
            {
                this.game.Main();
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("What Woul you like to buy");
        }
        public void BuyFromUser()
        {

        }

        public void Sell()
        {

        }
    }



}

