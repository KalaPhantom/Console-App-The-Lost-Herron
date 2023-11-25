class layout{
    private const int Height = 20;
    private const int With = 40;

    public static void Layout1()
    {
        Console.SetCursorPosition(10,5);
        Console.WriteLine("_______________________________________________________");




        
    }

    public static void Reset_or_Center(string a ){ // -> center a passed string on the console
        
        Console.SetCursorPosition((Console.WindowWidth - a.Length) / 2, Console.CursorTop);
        Console.WriteLine(a);
        
   
    }




}