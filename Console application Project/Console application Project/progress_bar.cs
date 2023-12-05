using player;

namespace Testtt_1
{
    class progress_bar
    {

        public static void bar1()
        {
            layout.border_layout();
            for (int i = 0; i <= 50; i++) // Intitiate the number of times the lopp will repeat
            {
                for (int j = 0; j <= i; j++) // Complements the values from the outer loop 
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow; // Sets the console text color to red
                    string boom_bars = "\u2551"; // ANSI Code to print a specific character 
                    Console.Write(boom_bars);
                    Console.ResetColor();
                }
                Console.Write(" {0}/50", i); 
                Console.SetCursorPosition(1, 12);
                Thread.Sleep(20); // Adds a delay on the loop
                
            }
            Console.WriteLine("\n\tPress any key to continue");
            Console.ReadLine(); 
        }

        
        public static void healthbar(int health){

            while (health <= Player.health){
                for (int a = 0; health <= Player.health; a++ ){
                     Console.Write("|");
                }
            }
        }

        public static void Health_Bar(){
            
        }




    }
}