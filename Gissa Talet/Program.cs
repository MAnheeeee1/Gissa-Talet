namespace Gissa_Talet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapad av Manh Dao
            Console.WriteLine("Detta är ett gissa nummret spel!\n1. Starta spelet\n2. Avsluta programmet");
            string svar = Console.ReadLine();
            int gissning = 0;
            switch(svar)
            {
                case "1":
                Random tal = new Random();
                    Console.WriteLine("Vad ska talet högst vara??");
                    int talet = tal.Next(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Skriv din gissning:");
                    gissning = int.Parse(Console.ReadLine());
                    while (gissning != talet )
                    {
                        Console.WriteLine($"Din gissning är för {HurNäraSvaret(gissning, talet)}\n Gissa igen, Ge inte Up!:");
                        gissning = int.Parse(Console.ReadLine());
                    }
                    if (gissning == talet )
                    {
                        Console.WriteLine("Bra gissad du hade rätt!");
                    }
                    break;
            }
            

        }
        static string HurNäraSvaret (int gissning, int talet)
        {
            string högtellerlåg = "";
            if (gissning < talet) 
            {
                högtellerlåg = "låg";
            }
            else
            {
                högtellerlåg = "hög";
            }
            return högtellerlåg;
        }
    }
}