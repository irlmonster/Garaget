namespace Ovning_5_Garaget.UI
{
    public class MainMenu
    {
        public MainMenu()
        {
            // Huvudmenyn
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Garaget:");
                Console.WriteLine("1. Skapa garage");
                Console.WriteLine("2. Sök på  ");
                Console.WriteLine("3. ");
                Console.WriteLine("0. ");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Välj ett alternativ (1-3): ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        // något
                        
                        break;
                    case "2":
                        // något
                        Console.WriteLine();
                        string StringInput = Console.ReadLine();

                        break;
                    case "3":
                        //Något
                        Console.WriteLine();

                        break;
                    case "0":
                        // Avlsuta programmet
                        isRunning = false;
                        Console.WriteLine();
                        break;
                    default:
                        // Ogiltigt val, kör menyn igen.
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
