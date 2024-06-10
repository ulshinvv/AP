using PGGame;

namespace AddapterPatern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComputerGame game1 = new ComputerGame(
                "Minecraft", PegiAgeRating.P12,29.99,500,2,8,4, 2.8
            );
            // адаптер ComputerGameAdapter
            PCGame adaptedGame1 = new ComputerGameAdapter(game1);

            // Демонстрация использования адаптера
            Console.WriteLine($"Title: {adaptedGame1.getTitle()}");
            Console.WriteLine($"Pegi Allowed Age: {adaptedGame1.getPegiAllowedAge()}");
            Console.WriteLine($"Is Triple-A Game: {adaptedGame1.isTripleAGame()}");
            Requirements requirements = adaptedGame1.getRequirements();
            Console.WriteLine($"GPU Memory: {requirements.getGpuGb()} GB");
            Console.WriteLine($"Disk Space: {requirements.getHDDGb()} GB");
            Console.WriteLine($"RAM: {requirements.getRAMGb()} GB");
            Console.WriteLine($"CPU Speed: {requirements.getCpuGhz()} GHz");
            Console.WriteLine($"CPU Cores: {requirements.getCoresNum()}");

        }

    }


}
