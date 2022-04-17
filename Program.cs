using System;

namespace Hello
{
    class Program
    {

        static void Main(string[] args)
{
        int Number = 4;
        int PlayerNum;
        int m;

        Console.WriteLine("Pick a number beetween 1 and 4");
        Console.WriteLine("Write 1 if you want to quit");
        m = Convert.ToInt32(Console.ReadLine());

        switch (m)
        {
            case 1:
                Environment.Exit(0);
                break;
            case 2:
                do
                    {
                        Console.WriteLine("Write a number!");
                        PlayerNum = Convert.ToInt32(Console.ReadLine());
                        if(PlayerNum == Number)
                        {
                            Console.WriteLine("Congrats! You found the number!");
                        } 
                        else
                            Console.WriteLine("Wrong!Try again.");
                    }
                    while(PlayerNum != Number);
                    break;
            default:
            break;
        }
        
}       
    }
}


    