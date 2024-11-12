namespace DGD203.Project.BaranParkin
{
    public class Player
    {
        //players name and rank variables
        public string Name;
        public string Rank;

        //set the player's name and rank
        public Player(string name, string rank)
        {
            Name = name;
            Rank = rank;
            //telling the player they're ready to command the spaceship
            Console.WriteLine($"Player '{Name}', Rank: {Rank}, is ready to command the spaceship.");
        }
    }
}