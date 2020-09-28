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
        private Character _player;
        private bool _gameOver = false;
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

        public void GetInput(string option1, int damage1, string option2, int damage2, string query)
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

        public void EquipWeapon()
        {
            GetInput(_bow.name, _claymore.name, "Please select a weapon");
            char input = ' ';
            if(input == '1')
            {
                _player.AddItemToInventory(_bow, 0);
                _player.AddItemToInventory(_dagger, 1);
            }
            else
            {
                _player.AddItemToInventory()
            }
 
        }

        public void CreateCharacter()
        {

        }

        //This is where the player will fight the enemy.
        public void BattleLoop()
        {

        }

    }
}
