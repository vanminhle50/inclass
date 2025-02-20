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
                Console.Write("player A(You): ");
                string playerA = Console.ReadLine();
                if (Convert.ToInt32(playerA) < 1 || Convert.ToInt32(playerA) > 3)
                    Console.WriteLine("Enter again!");
                while ((Convert.ToInt32(playerA) > 0) && (Convert.ToInt32(playerA) < 4))
                {
                    Random computer = new Random();

                    string playerB = Convert.ToString(computer.Next(1, 3));
                    Console.WriteLine("Player B(Computer): " + playerB);
                    if (playerA == "1" && playerB == "1")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Tie game");
                        Console.WriteLine("------------------------------------------");
                    }
                    else if (playerA == "1" && playerB == "2")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("B(Computer) wins");
                        b++;
                        Console.WriteLine("------------------------------------------");
                    }
                    else if (playerA == "1" && playerB == "3")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("A(You) wins");
                        Console.WriteLine("------------------------------------------");
                        a++;
                    }
                    else if (playerA == "2" && playerB == "1")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("A(You) wins");
                        Console.WriteLine("------------------------------------------");
                        a++;
                    }
                    else if (playerA == "2" && playerB == "2")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Tie game");
                        Console.WriteLine("------------------------------------------");
                    }
                    else if (playerA == "2" && playerB == "3")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("B(Computer) wins");
                        Console.WriteLine("------------------------------------------");
                        b++;
                    }
                    else if (playerA == "3" && playerB == "1")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("B(Computer) wins");
                        Console.WriteLine("------------------------------------------");
                        b++;
                    }
                    else if (playerA == "3" && playerB == "2")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("A(You) wins");
                        Console.WriteLine("------------------------------------------");
                        a++;
                    }
                    else if (playerA == "3" && playerB == "3")
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Tie game");
                        Console.WriteLine("------------------------------------------");
                    }
                    round++;
                    break;
                }
            }

            Console.WriteLine("---------------Final score----------------");
            Console.WriteLine("A Player (You)     : " + a + " score");
            Console.WriteLine("B Player (Computer): " + b + " score");
            Console.WriteLine("------------------------------------------");
            if (a > b)
            {
                Console.WriteLine("A (You) player wins");
            }
            else
            {
                if (b > a)
                {
                    Console.WriteLine("B (Computer) player wins");
                }
                else
                {
                    Console.WriteLine("Tie game");
                }
            }
        }
    }
}
