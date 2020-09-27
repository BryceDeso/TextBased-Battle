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
            Console.WriteLine("Please Select a weapon.");
            Console.WriteLine(_bow.name);
            Console.WriteLine(_claymore.name);
 
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
