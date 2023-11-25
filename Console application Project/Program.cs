using Testtt_1;


// This portion is the main activity

namespace tesst_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            menu.TitleScreen();
            layout.Layout1();
            

            // movement.a = Console.ReadLine();

            // main menu
            menu.mainmenu1();
            // account creation
            menu.acc_creation();

      
            Console.Clear();
            progress_bar.bar1();
            Console.Write("\n\nWelcome");
            Console.Clear();

            decorations.headphone();
            Console.Clear();
            
            // Call test for the title screens

            
            menu.EndingScreen();
            menu.Game_Over();







            Console.ReadLine();
        
        
        }
    }


}
