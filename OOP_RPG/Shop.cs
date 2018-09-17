using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
         List<Armor> ArmorsBag { get; set; }
         List<WeaponsBag> WeaponsBag { get; set; }
         List<Potions> Potions { get; set; }
         List<Inventory> Inventory { get; set; }
        public  Game game { get; set; }

        public Shop(Game game)
        {
            this.game = game;
            this.AddArmor("WoodenArmor", 10, 2, 3);
            this.AddArmor("Metal Armor", 20, 5, 7);
            this.AddWeapon("Sword", 10, 2, 3);
            this.AddWeapon("Axe", 12, 3, 4);
            this.AddWeapon("Longsword", 20, 5, 7);
            this.AddPotion(5, "Healing Potion");



        }
            public void AddArmor(string name, int originalValue, int resellValue, int defense)
            {
                var armor = new Armor(name, originalValue, resellValue, defense);
                this.ArmorsBag.Add(armor);
            }

            public void AddWeapon(string name, int originalValue, int resellValue, int strength)
            {
                var weapon = new WeaponsBag(name, originalValue, resellValue, strength);
                this.WeaponsBag.Add(weapon);
            }

            public void AddPotion(int hp, string name )
            {
                var potion = new Potions(hp, name);
                this.Potions.Add(potion);
            }

            public void GetInventory(string name, int originalValue, int id)
            {
                var inventory = new Inventory(name, originalValue, id);
                    foreach(var c in this.WeaponsBag)
                        {
                            inventory.Name = c.Name;
                            inventory.OriginalValue = c.OriginalValue;
                            inventory.ID++;    
                            this.Inventory.Add(inventory);
                            
                        }
                    foreach (var c in this.ArmorsBag)
                    {
                        inventory.Name = c.Name;
                        inventory.OriginalValue = c.OriginalValue;
                        inventory.ID++;
                        this.Inventory.Add(inventory);
                    }
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
                foreach(var c in this.Inventory)
                {
                    Console.WriteLine(this.Inventory.IndexOf(c) + c.Name + " costs " + c.OriginalValue);
                Console.WriteLine($" To buy an Item Emter the Index Of the Item or To  Go To The Main Menu Enter  \"r\" or \" return\"");
                }
                var input = Console.ReadLine();
                    
                    if (input = Inventory.ID)
                    {
                        this.Sell();
                    }
                    else if (input.Equals("r") || input.Equals("return"))
                    {
                        this.game.Main();
                    }
            }
            public void BuyFromUser()
            {

            }
            
            public void Sell()
            {

            }
    }
        
    
       
 }

