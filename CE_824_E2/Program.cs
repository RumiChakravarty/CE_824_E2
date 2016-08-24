using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_824_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean ex_bool = true;
            Console.WriteLine(ex_bool);
            myTest("dotNet");
            myWrite("Good Morning");
            Console.Write("Roses ");
            Console.Write("are\n");
            Console.WriteLine("   R E D\n");
            Console.Write("Violets are \n");
            Console.Write("Blue.\n");
            Console.WriteLine("I am a developer");
            Console.Write("  and so are you\n");

            // string qq = writeSomething();
            //Console.Write(qq);
            Console.Write(writeSomething());
        }
        static void myWrite(string message)
        {
            Console.Write(message + "pizzaz");
            Console.Write("ubl" + message + "pizza");
         

        }
        static void myTest(string msg)
        {
            Console.WriteLine("This class is Fun as we r learning new things");
            Console.Write(msg + "   Class");
            Console.ReadLine();

        }
        static string writeSomething()
        {
            return @"Please write something

We will have to do more during Lab hour

Thank You";
        }

    }
}
