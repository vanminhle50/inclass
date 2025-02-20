namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game Rock Paper Scissors");
            int totle = 5;
            int round = 1;
            int a = 0,
                b = 0;
            while (round <= totle)
            {
                Console.WriteLine("Game round - " + round);
                Console.WriteLine("1-Rock, 2-Paper, 3-scissors:");
                Console.Write("player A: ");
                string playerA = Console.ReadLine();
                Console.Write("player B: ");
                string playerB = Console.ReadLine();

                if (playerA == "1" && playerB == "1")
                {
                    Console.WriteLine("Tie game");
                }
                else if (playerA == "1" && playerB == "2")
                {
                    Console.WriteLine("B wins");
                    b++;
                }
                else if (playerA == "1" && playerB == "3")
                {
                    Console.WriteLine("A wins");
                    a++;
                }
                else if (playerA == "2" && playerB == "1")
                {
                    Console.WriteLine("A wins");
                    a++;
                }
                else if (playerA == "2" && playerB == "2")
                {
                    Console.WriteLine("Tie game");
                }
                else if (playerA == "2" && playerB == "3")
                {
                    Console.WriteLine("B wins");
                    b++;
                }
                else if (playerA == "3" && playerB == "1")
                {
                    Console.WriteLine("B wins");
                    b++;
                }
                else if (playerA == "3" && playerB == "2")
                {
                    Console.WriteLine("A wins");
                    a++;
                }
                else if (playerA == "3" && playerB == "3")
                {
                    Console.WriteLine("Tie game");
                }
                else
                {
                    Console.WriteLine("invalid input, we should be not here.");
                }

                round++;
            }
            Console.WriteLine("Final score:");
            Console.WriteLine("A Player: " + a + " score");
            Console.WriteLine("B Player: " + b + " score");
            if (a > b)
            {
                Console.WriteLine("A player wins");
            }
            else
            {
                if (b > a)
                {
                    Console.WriteLine("B player wins");
                }
                else
                {
                    Console.WriteLine("Tie game");
                }
            }
        }
    }
}
