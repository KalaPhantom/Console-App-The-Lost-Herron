using Story;
using Testtt_1;


// This portion is the main activity

namespace tesst_1
{
    internal class Program
    {
     
        public static void Main(string[] args)
        {

            



          bool a = true;

            do{
                Console.Clear();

                

                 menu.TitleScreen();
                 
                 layout.border_layout();
            

                 // movement.a = Console.ReadLine();

                 // main menu
                  menu.mainmenu1();
                  // account creation
                  menu.acc_creation();
                  story.Dialogue_1();
                  
      
                  Console.Clear();
                  progress_bar.bar1();
                  Console.Write("\n\nWelcome");
                  Console.Clear();

                  decorations.headphone();
                  Console.Clear();
            
                   // Call test for the title screens

                  Console.ReadLine();
                  menu.EndingScreen();
                  Console.ReadLine();
                  menu.Game_Over();
                  Console.ReadKey();

                  Console.Clear();
                  Console.Write(">>Press Esc button to exit to the console \n>>Press Enter to Go back to the title screen...... ");
                  ConsoleKeyInfo key = Console.ReadKey(true);


                 
                  switch (key.Key){
                    case ConsoleKey.Escape:
                    a = false;
                    break;

                    case ConsoleKey.Enter:
                    a = true;
                    break;

                    default:
                    a = false;
                    break;

                  }

            }while (a == true);
        
        
        }
    }
}
