using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    struct Item
    {
        public string name;
        public int damage;
    }

    class Game
    {
        private bool _gameOver = false;
        private Player _player;
        private Item _bow;
        private Item _claymore;
        private Item _dagger;

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

        }

        //Gets input from the player.
        public void GetInput(string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);

            char input = ' ';
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        //This overload of GetInput allows you to display the damage of items alongside the item name.
        public void GetInput(string option1, int damage1, string option2, int damage2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("Damage: " + damage1);
            Console.WriteLine("\n2. " + option2);
            Console.WriteLine("Damage: " + damage2);

            char input = ' ';
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
            _bow.damage = 10;
            _bow.name = "Bow";
            _claymore.damage = 20;
            _claymore.name = "Claymore";
            _dagger.damage = 5;
            _dagger.name = "Dagger";
        }

        //Lets the player pick a weapon and equip them in their inventory.
        public void EquipWeapon()
        {
            GetInput(_bow.name, _bow.damage, _claymore.name, _claymore.damage, "Welcome Player! Please select a weapon for combat!");
            char input = ' ';
            if(input == '1')
            {
                _player.AddItemToInventory(_bow, 0);
                _player.AddItemToInventory(_dagger, 1);
            }
            else
            {
                _player.AddItemToInventory(_claymore, 0);
                _player.AddItemToInventory(_dagger, 1);
            }
        }

        /*Will print the players inventory.
        public void PrintInventory(Item[] inventory)
        {
            for(int i = 0; i + 1; i++)
            {

            }
        }
        */

        public void CreateCharacter()
        {
            _player = new Player(100, 10);
            EquipWeapon();
            Console.WriteLine(_player);

        }

        //This is where the player will fight the enemy.
        public void BattleLoop()
        {

        }

    }
}
