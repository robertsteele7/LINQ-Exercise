using System.Collections.Generic;
using System.Xml.Linq;

namespace LINQ
{
    //Create a list of video game names..
    //Order the list of games by length of the game name.
    //Use the lambda expression in this exercise as well

    public class Program
    {
        static void Main(string[] args)
        {
            var Games = new List<string>
            {"PACMAN","SPACEINVADERS","MARIO","QBERT","W.O.W.","TETRIS"

            };
            IEnumerable<String> Order = Games.OrderBy(x => x.Length);
            foreach (string Game in Order)
            {
                Console.WriteLine(Game);
            }
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        }
    }
}
