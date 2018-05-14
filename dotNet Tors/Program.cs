using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace dotNet_Tors
{
    class Hello
    {
        public void Speak()
        {
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Title = "My Super App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************************");
            Console.WriteLine("WELCOM");
            Console.WriteLine("****************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Test 1, 2, 3");
            Console.Beep(659, 900);
            Console.Beep(392, 300);
            Console.Beep(659, 900);
            Console.Beep(392, 300);
            Console.Beep(659, 900);
            Console.Beep(392, 300);
            Console.Beep();
            
            Console.Beep(659, 300);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Hello h = new Hello();
            h.Speak();
            Console.Beep(392, 300);
            Console.Clear();
            Console.Beep(6590, 900);
            DateTime dt = new DateTime(2018,04,22);
            Console.WriteLine("***Basic I/O*** {0}" ,dt);
            GetUser();
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);

            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);

            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);
            Console.Beep(587, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);

            Console.Beep(440, 120);
            Thread.Sleep(150);
            Console.Beep(262, 120);
            Thread.Sleep(130);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(440, 120);
            Thread.Sleep(130);

            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(415, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);

            Console.Beep(523, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);

            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(622, 120);
            Thread.Sleep(130);
            Console.Beep(659, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(130);
            Console.Beep(587, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);

            Console.Beep(440, 120);
            Thread.Sleep(150);
            Console.Beep(262, 120);
            Thread.Sleep(130);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(440, 120);
            Thread.Sleep(130);

            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(330, 120);
            Thread.Sleep(130);
            Console.Beep(523, 120);
            Thread.Sleep(130);
            Console.Beep(494, 120);
            Thread.Sleep(150);
            Console.Beep(440, 120);
        
        Console.ReadKey();
        }
        static void GetUser()
        {
            Console.Write("Your Name : ");
            string userName = Console.ReadLine();
            Console.Write("Your Age : ");
            string userAge = Console.ReadLine();
            ConsoleColor pColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hey {0}! you are {1} old", userName, userAge);
            Console.ForegroundColor = pColor;
        }
    }
}
