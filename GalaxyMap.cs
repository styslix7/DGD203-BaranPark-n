namespace DGD203.Project.BaranParkin
{
    public class GalaxyMap
    {
        //when you mentioned car can move from location A to location B in class, I wanted to do that with planets and galaxies instead of locations
        //a list of destinations in the galaxy
        public string[] Destinations = { "Alpha Centauri", "Andromeda", "Sirius", "Orion Nebula" };

        //showing available destinations to the player
        public void DisplayMap()
        {
            Console.WriteLine("Galaxy Map - Available Destinations:");
            for (int i = 0; i < Destinations.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Destinations[i]}");
            }
        }

        //choosing a destination based on player's input
        public string GetDestination(int choice)
        {
            if (choice > 0 && choice <= Destinations.Length)
            {
                return Destinations[choice - 1];
            }
            else
            {
                return "Unknown Destination";
            }
            //this part was the part that I can say ChatGPT did more than me, I asked what to do if player doesn't inputs any of the destinations I set, it gave me a code and I did little change
        }
    }
}