using System;
using System.Collections;

namespace About_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Please pick 7 Lotto numbers (between 1 to 40) & Press ENTER after each number ");
            ArrayList lotto = new ArrayList();
            for (int i = 0; i < 7; i++)
            {
                lotto.Add(Console.ReadLine());
            }
            while(true)
            {
                Random r = new Random();
                ArrayList blue = new ArrayList();
                while(true)
                {
                    if(blue.Count == 6)
                    {
                        break;
                    }
                    else
                    {
                        int temp = r.Next(1, 40);
                        if (!blue.Contains(temp))
                        {
                            blue.Add(temp);
                        }
                    }
                }
                // blue.Sort();
                Console.Write("\n   Results: ");
                for(int i = 0; i < blue.Count; i++)
                {
                    Console.Write(blue[i] + "\t");
                }
                int x = r.Next(1, 40);
                Console.WriteLine("\n\n   Bonus ball is:" + x + "\t");

                int count = 0;
                int result = 0;
                for(int i = 0; i < 6; i++)
                {
                    if (blue.Contains(Convert.ToInt32(lotto[i].ToString())))
                    {
                        result++;
                    }
                }
                Console.WriteLine("\n   " + result + " Lotto numbers matched!");

                if(x == Convert.ToInt32(lotto[6]))
                {
                    Console.WriteLine("\nBonus ball matched!");
                }
                count++;
                if(result == 6 && x == Convert.ToInt32(lotto[6]))
                {
                    Console.WriteLine("\n  Congradulation! You won! Total prize: $" + (count * 2));
                }
                else if(result == 6)
                {
                    Console.WriteLine("\n  Congradulation! You won! Total prize: $" + (count * 2));
                }
                else if(result == 5)
                {
                    Console.WriteLine("\n  Congradulation! You won! Total prize: $" + (count * 2));
                }
                else if (result == 4)
                {
                    Console.WriteLine("\n  Congradulation! You won! Total prize: $" + (count * 2));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n   Better luck next time O(∩_∩)O ~");
                }
                Console.ReadKey();
            }           
        }
    }
}
// Retrieved from http://www.cnblogs.com/275147378abc/p/4464261.html
