using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class robot
    {
        public string Name { get; set; }
        private int FullLevel { get; set; }


        public void Hello()
        {
            Console.WriteLine("你好,我叫{0}",Name);
        }

        public void Eat(int FoodCount)
        {
            if (FullLevel > 100)
            {
                return;
            }
            FullLevel = FullLevel + FoodCount;
        }
        public void Speak(string str)
        {
            if (FullLevel <=0 )
            {
                Console.WriteLine("我要死了");
                return;
            }
            if (str.Contains("名字") || str.Contains("姓名"))
            {
                this.Hello();
            }
            else if (str.Contains("从哪里"))
            {
                Console.WriteLine("来自火星");
            }
            else if (str.Contains("女朋友"))
            {
                Console.WriteLine("女朋友什么的不存在的!");
            }
            else if (str.Contains("男的") || str.Contains("女的"))
            {
                Console.WriteLine("你猜,猜对了就告诉你");
            }
            else {
                Console.WriteLine("你真是个哈批");
            }
            FullLevel--;
        }

        public void Speak1(string str)
        {
            if (FullLevel <= 0)
            {
                Console.WriteLine("我要死了");
                return;
            }
            if (str.Contains("名字") || str.Contains("姓名"))
            {
                this.Hello();
            }
            else if (str.Contains("你是"))
            {
                Console.WriteLine("我是你朋友");
            }
            else if (str.Contains("男朋友"))
            {
                Console.WriteLine("男朋友什么的不存在的!");
            }
            else if (str.Contains("男的") || str.Contains("女的"))
            {
                Console.WriteLine("你猜,猜对了就告诉你");
            }
            else
            {
                Console.WriteLine("你真是个哈批");
            }
            FullLevel--;
        }
    }
}
