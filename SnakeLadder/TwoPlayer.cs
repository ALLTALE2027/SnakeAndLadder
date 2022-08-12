using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class TwoPlayer
    {


        static int count = 0;  // to count total no. of diece throws by player 1 and 2
        int player1 = 0;
        int player2 = 0;



        Random random = new Random();

        string[] options = { "No Play", "Ladder", "Snake" };



        protected int Posn(int position)
        {
            

            count++;
            int dieceNum = random.Next(1, 7);

            string choice = options[random.Next(0, 3)];

            switch (choice)
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


            if (choice == "Ladder")
            {
                Console.WriteLine("player gets to  plays again!!!");
                Posn(position);
            }

            return position;
        }




        public void Game()
        {
            var player1_throws = new List<int>();
            var player2_throws = new List<int>();


            while (player1 < 100 && player2 < 100)
            {

                player1 = Posn(player1);
                Console.WriteLine("Player 1 position : " + player1);
                player1_throws.Add(player1);

                player2 = Posn(player2);
                Console.WriteLine("Player 2 position : " + player2);
                player2_throws.Add(player2);
            }


            Console.WriteLine("Player 1 positions are");
            foreach (var i in player1_throws)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Player 2 positions are");
            foreach (var i in player2_throws)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Total no. of throws are: " + count);
            Console.WriteLine();


            if (player1 == 100)
                Console.WriteLine("Player 1 is winner!!!!!");
            else
                Console.WriteLine("Player 2 is winner!!!!!");


            

        }
    }
}
