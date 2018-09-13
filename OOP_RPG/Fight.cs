using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }
        
        public Fight(Hero hero, Game game) {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
            this.AddMonster("Squid", 9, 8, 20);
            this.AddMonster("DeathEater", 15, 8, 14);
            this.AddMonster("GrindelWard", 19, 20, 18);
            this.AddMonster("DarkLord", 20, 20, 19);
            
            //for last Monster
            //this.monster = this.Monsters.Last() ;

            //for Second Monster
            //int MonsterNumber = 2;

            //for First Monster with less tham 20 hit points
            //this.monster = this.Monsters.Find(mons => mons.OriginalHP < 20);

            // for First Monster with strength atleat 11
            //this.monster = this.Monsters.Find(mons => mons.Strength > 10);

            


        }

        public void AddMonster(string name, int strength, int defense, int hp) {
            var monster = new Monster(name, strength, defense, hp);
            this.Monsters.Add(monster);
        }
        
        public void Start() {
            Random rnd = new Random();
            int MonsterNumber = rnd.Next(4);
            this.monster = this.Monsters[MonsterNumber];
            Console.WriteLine("You've encountered a " + monster.Name + "! " + monster.Strength + " Strength/" + monster.Defense + " Defense/" +
            monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1") {
                this.HeroTurn(monster);
            }
            else { 
                this.game.Main();
            }
        }
        
        public void HeroTurn(Monster monster){
           var compare = hero.Strength - monster.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
                monster.CurrentHP -= damage;
           }
           else{
               damage = compare;
                monster.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage!");
           
           if(monster.CurrentHP <= 0){
               this.Win(monster);
           }
           else
           {
               this.MonsterTurn(monster);
           }
           
        }
        
        public void MonsterTurn(Monster monster){
           int damage;
           var compare = monster.Strength - hero.Defense;
           if(compare <= 0) {
               damage = 1;
               hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               hero.CurrentHP -= damage;
           }
           Console.WriteLine(monster.Name + " does " + damage + " damage!");
           if(hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.Start();
           }
        }
        
        public void Win(Monster monster) {
            Console.WriteLine(monster.Name + " has been defeated! You win the battle!");
            hero.Gold = hero.Gold + monster.Gold;
            game.Main();
        }
        
        public void Lose() {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }
        
    }
    
}