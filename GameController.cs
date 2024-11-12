namespace DGD203.Project.BaranParkin
{
    public class GameController
    {
        //declaring variables for player, spaceship, and galaxy map
        private Player player;
        private SpaceShip spaceship;
        private GalaxyMap galaxyMap;

        //set up the game with player, spaceship, and galaxy map
        public GameController(Player player, SpaceShip spaceship, GalaxyMap galaxyMap)
        {
            this.player = player;
            this.spaceship = spaceship;
            this.galaxyMap = galaxyMap;
        }

        //starting the game and handling actions
        public void StartMission()
        {
            //printing a message to tell the player they are in command
            Console.WriteLine($"EDI: {player.Name}, you are now in command of the '{spaceship.Name}'. Ready to start?");
            spaceship.ReportStatus();

            //show the galaxy map with available destinations
            galaxyMap.DisplayMap();
            Console.Write("Select a destination (1-4): ");
            int choice = int.Parse(Console.ReadLine());
            string destination = galaxyMap.GetDestination(choice);

            //simulate traveling to the destination
            Console.WriteLine($"EDI: Setting course for {destination}...");
            spaceship.Accelerate(100);
            spaceship.Refuel(-20);
            spaceship.DamageShield(10);
            spaceship.ReportStatus();

            //ending the mission
            Console.WriteLine("Mission accomplished! Safe journey, Captain.");
        }
    }
}