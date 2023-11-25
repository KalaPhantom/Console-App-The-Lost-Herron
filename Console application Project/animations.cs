

class anima
{

    public static void anima1(string a)
    {
       foreach (char c in a){
        Console.Write(c);
        Thread.Sleep(30);
       }
    }
    public static void anima2(string a, string b){ // Accepts two string variable -> preferred with the concatination
        foreach (char c in a){
        Console.Write(c);
        Thread.Sleep(30);
       

       }
       foreach(char d in b){
        Console.Write(" "+ d);
        Thread.Sleep(50);
       }

    }
    public static void Title_and_gameover(string a){
        foreach(char b in a){
            Console.Write(b);
            Thread.Sleep(1);
        }



    }
}

   