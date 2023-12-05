
using player;

namespace Story{
    class story{

        public static void Dialogue_1() // This is the welcoming dialogue
        { 
            Console.Clear();
            layout.border_layout();
            anima.anima1($"On the cheers of the crowd, A hero by the name of {Player.Player_name} enters the stage" );
            
            Console.WriteLine("\n");
            layout.def_layout();
            anima.anima1("With all of the cheering crown and embracing glory, you go out on your journey");
            Console.WriteLine("\n");
            layout.def_layout();
            anima.anima1("Bearing the promise of having glory, and returning as a hero");
            Console.ReadLine();
            Player.health = 100;
            Player.damage = 1;
            Player.armor = 1;
            
            
        }
    }
}
