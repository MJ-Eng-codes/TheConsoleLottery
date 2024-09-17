using System.Security.Cryptography.X509Certificates;

namespace TheConsoleLottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till The Console Lottery!");
                        
            Console.WriteLine("Hur många lotter vill du köpa. Du kan köpa max 5 lotter.");
            int antal = GetValidInput(1,5);
            int[] sizeticket = new int[antal];

            do
            {
               
                    for (int i = 0; i < antal; i++)
                    {
                        Console.WriteLine("Välj ett nummer mellan 1-50");
                        sizeticket [i] = GetValidInput(1,50);
                        
                    }
                         
              
            }
            while (antal <= 5) ;
            

        }

    

        //Användarinmatning
        static int GetValidInput(int min, int max)
        {
            int input;
            do
            {
                if (int.TryParse(Console.ReadLine(), out input) && input >= min && input <= max)
                {
                    break;
                }
                Console.Write($"Invalid input\nEnter a number between {min} and {max}: ");

            } while (true);
            return input;
        }
        //Generera slumpmässiga tal
        //static int GetNumber()
            
                // Skapa en ny instans av Random-klassen
                //Random random = new Random();

                // Generera ett slumpmässigt heltal mellan 1 och 50 (inklusive)
                //int randomNumber = random.Next(1, 51);

                // Skriv ut det slumpmässiga nummret i consolen
                //Console.WriteLine("Slumpmässigt tal: " + randomNumber);
               // return randomNumber;
            
            

        }
}
