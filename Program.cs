namespace DGD203.Project.BaranParkin

//run the program.cs file directly without enabling debugging mode
//my vehicle is not a car and is actually a spaceship, inspired from mass effect
//I also made the ai EDI in mass effect and added some dialogue in a space theme

{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the player for their name and rank
            Console.Write("Enter your name, Captain: ");
            string playerName = Console.ReadLine();

            Console.Write("Enter your rank: ");
            string playerRank = Console.ReadLine();

            //create the player with their name and rank
            Player player = new Player(playerName, playerRank);

            //ask for spaceship model and year
            Console.Write("Enter spaceship model: ");
            string model = Console.ReadLine();

            Console.Write("Enter spaceship year of manufacture: ");
            int year = int.Parse(Console.ReadLine());

            //create the spaceship with the model and year
            SpaceShip spaceship = new SpaceShip(model, year);
            GalaxyMap galaxyMap = new GalaxyMap();

            //start the game and run the mission
            GameController gameController = new GameController(player, spaceship, galaxyMap);
            gameController.StartMission();
        }
    }
}