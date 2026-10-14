using System;
using System.Collections;

public static class Learn
{
   
    public static void Main()
    {
        Random random = new Random();
        int x = 0;
    int answer;

        Console.WriteLine("NUMBER GUESSING GAME \n");
        answer = random.Next(0,100);
        
        x = Convert.ToInt32(Console.ReadLine());

        while(x != answer)
        {
            if (x < answer )
            {
                Console.WriteLine("THIS NUMBER IS TOO SMALL TRY AGAIN");
            }
            else if (x > answer)
            {
                Console.WriteLine("X IS TOO BIG CHOOSE A NEW ONE");
                
            }

            x = Convert.ToInt32(Console.ReadLine());
            
   





        }

        Console.WriteLine("YOU ARE CORRECT THE RIGHT ANSWER IS " + answer);


    }
}