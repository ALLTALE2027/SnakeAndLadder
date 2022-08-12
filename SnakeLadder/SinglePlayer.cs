using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SinglePlayer
    {
        public void Game()
        {

            int throwNum = 0;

            var track = new List<int>();
            int position = 0;

            Random random = new Random();

            string[] options = { "No Play", "Ladder", "Snake" };


            while (position < 100)
            {


                int dieceNum = random.Next(1, 7);

                switch (options[random.Next(0, 3)])
                {
                    case "No Play":
                        Console.WriteLine("No play , player stays in same position");
                        break;

                    case "Ladder":
                        Console.WriteLine("Ladder , player moves ahead on board");
                        if (position + dieceNum <= 100)
                        {
                            position += dieceNum;
                        }


                        break;

                    case "Snake":
                        Console.WriteLine("Snake , player bitten by snake , he moves behind");
                        if (position - dieceNum >= 0)
                        {
                            position -= dieceNum;
                        }

                        if (position - dieceNum < 0)
                        {
                            position = 0;
                        }
                        break;
                }

                Console.WriteLine("positon : " + position);
                throwNum++;
                track.Add(position);
            }

            
           
            Console.WriteLine("number of times the dice was played to win the game " + throwNum);
            Console.WriteLine();
            Console.WriteLine(" positions after each throw");
            foreach (int i in track)
            {
                Console.Write(i + " ");

            }



        }
    }
}
