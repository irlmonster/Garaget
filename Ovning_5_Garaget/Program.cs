using Ovning_5_Garaget.Handlers;
using Ovning_5_Garaget.UI;
using Ovning_5_Garaget.Vehicles;


namespace Ovning_5_Garaget
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapa ett menyobjekt och sen kör vi metoden Run 
            var menu = new MainMenu();
            menu.Run();
            



        }
    }
}
