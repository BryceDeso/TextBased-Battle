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
            
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
