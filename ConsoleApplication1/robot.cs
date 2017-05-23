using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class robot
    {
        public string Name { get; set; }//机器人的名字属性
        private int FullLevel { get; set; }//机器人的饥饿级别


        public void Hello()   // 打招呼方法
        {
            Console.WriteLine("你好,我叫{0}",Name);  
        }

        public void Eat(int FoodCount)  //饥饿级别方法
        {
            if (FullLevel > 100)
            {
                return;
            }
            FullLevel = FullLevel + FoodCount;//饥饿级别等于  饥饿级别+喂食数量
        }
        public void Speak(string str)//对话方法
        {
            if (FullLevel <=0 )  //当饥饿级别小于或者等于0的时候,提示饿死了
            {
                Console.WriteLine("我要死了");
                return;
            }
            if (str.Contains("名字") || str.Contains("姓名"))  //contains方法,如果有其中的字符串
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
            FullLevel--;//饥饿级别每次减1
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
