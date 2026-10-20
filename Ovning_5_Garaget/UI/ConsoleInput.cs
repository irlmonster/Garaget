using Ovning_5_Garaget.Validation;

namespace Ovning_5_Garaget.UI
{
    // Hjälpklass för inläsning från konsolen.
    // Varje metod frågar igen tills svaret är giltigt, så programmet aldrig kraschar på dålig input.
    public static class ConsoleInput
    {
        // Läser ett regnummer och returnerar det i normaliserat format (t.ex. "ABC123")
        public static string ReadRegNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (RegNumberValidation.IsValid(input))
                {
                    return RegNumberValidation.Normalize(input!); // här litar vi på att det inte är null eftersom vi kollat det tidigare
                }

                ConsoleOutput.WriteError("Ogiltigt regnummer. Formatet är tre bokstäver, två siffror och en siffra eller bokstav (tex. ABC123).");
            }
        }
    }
}