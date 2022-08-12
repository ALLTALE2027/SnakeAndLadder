namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game!!!");

            Console.WriteLine("Select the choices from below");
            Console.WriteLine("1. For singe player");
            Console.WriteLine("2. For two players");
            int ans=int.Parse(Console.ReadLine());


            switch (ans) 
            {
                case 1: SinglePlayer single = new SinglePlayer();
                         single.Game();
                    break;

                case 2: TwoPlayer twoPlayer = new TwoPlayer();
                          twoPlayer.Game();
                    break;

                default: Console.WriteLine("Enter the correct choice");
                    break;
            }



        }
    }
}