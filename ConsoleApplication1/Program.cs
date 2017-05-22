using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            robot rb1 = new robot();
            robot rb2 = new robot();

            Console.WriteLine("请选择机器人:1.小娜  2.小冰");
            string select = Console.ReadLine();
            switch (select)
            {
                
                case "1":
                    rb1.Name = "小娜";
                    rb1.Eat(5);
                    rb1.Hello();
                    while (true)
                    {
                        string line = Console.ReadLine();
                        rb1.Speak(line);
                    }
                    break;

                case "2":
                    rb2.Name = "小冰";
                    rb2.Eat(5);
                    rb2.Hello();
                    while (true)
                    {
                        string line = Console.ReadLine();
                        rb2.Speak1(line);
                    }
                    break;
            }
            
        }
    }
}
