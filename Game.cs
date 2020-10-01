﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    struct Item
    {
        public string name;
        public int damage;
        public int healthBoost;
    }

    class Game
    {
        private bool _gameOver = false;
        private Player _player;
        private Wizard _wizard;
        private Item _bow;
        private Item _claymore;
        private Item _healthPotion;

        //Run the game
        public void Run()
        {
            Start();

                while (_gameOver == false)
                {
                Update();
                }

            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            //_player = new Player(100, 10);
            InitalizeItems();
            CreateCharacter();
        }

        //Repeated until the game ends
        public void Update()
        {
            BattleLoop();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thanks for playing!");
        }

        public void CreateCharacter()
        {
            _player = new Player(100, 10);
            _wizard = new Wizard();
            EquipWeapon();

        }

        //Gets input from the player.
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1." + option1);
            Console.WriteLine("2." + option2);

            input = ' ';
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        //This overload of GetInput allows you to display the damage of items alongside the item name.
        public void GetInput(out char input, string option1, int damage1, string option2, int damage2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("Damage: " + damage1);
            Console.WriteLine("\n2. " + option2);
            Console.WriteLine("Damage: " + damage2);

            input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        //Sets values to any items added to game.
        public void InitalizeItems()
        {
            _bow.damage = 15;
            _bow.name = "Bow";
            _claymore.damage = 20;
            _claymore.name = "Claymore";
            _healthPotion.name = "Health potion";
            _healthPotion.healthBoost = 50;
        }

        //Lets the player pick a weapon and equip them in their inventory.
        public void EquipWeapon()
        {
            char input = ' ';
            GetInput(out input, _bow.name, _bow.damage, _claymore.name, _claymore.damage, "Welcome Player! Please select a weapon for combat!");
            if (input == '1')
            {
                _player.AddItemToInventory(_bow, 0);
                _player.AddItemToInventory(_healthPotion, 1);
                _player.EquipItem(_player, 0);
            }
            else
            {
                _player.AddItemToInventory(_claymore, 0);
                _player.AddItemToInventory(_healthPotion, 1);
                _player.EquipItem(_player, 0);
            }            
        }

        //Prints the player's inventory and allows them to select an item.
        public void ViewInventory(Player player)
        {
            Item[] inventory = player.GetInventory();

            char input = ' ';
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine("\n" +(i + 1) + ". " + inventory[i].name + " \n Damage: " + inventory[i].damage + "\nHealth Regen: " + inventory[i].healthBoost);
            }

            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {
                        Console.WriteLine("You already have " + inventory[0].name + "equipped.");
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("You take a sip from the " + inventory[1].name + "!");
                        Console.WriteLine("You gain " + inventory[1].healthBoost + " health!");
                        _player.HealPlayer(_player, 1);
                        break;
                    }
            }
        }

        //This is where the player will fight the enemy.
        public void BattleLoop()
        {
            Console.WriteLine("FIGHT!");

            while (_player.GetHealth() > 0 && _wizard.GetHealth() > 0)
            {                
                _player.PrintStats(_player);
                _wizard.PrintStats(_wizard);

                char input = ' ';
                GetInput(out input, "Attack", "Open inventory(WARNING:Opening inventory takes your turn!)", "Player please choose a action.");
                if (input == '1')
                {
                    _player.Attack(_wizard);
                    Console.WriteLine("Player delt" + _player.GetDamage() + " to Wizard.");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadKey();
                }
                else if (input == '2')
                {
                    ViewInventory(_player);
                }

                _wizard.Attack(_player);
                Console.WriteLine("Wizard delt " + _wizard.GetDamage() + " to Player.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadKey();
                Console.Clear();
            }
            //Checks to see who has won the fight and displays text depending on who won.
            if(_player.GetHealth() > _wizard.GetHealth())
            {
                Console.WriteLine("The Evil wizard has been defeated!");
                Console.WriteLine("Press enter to continue!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The Evil Wizard has won...");
                Console.WriteLine("Press enter to continue...");
                Console.ReadKey();
            }

            _gameOver = true;
        }
    }
}
