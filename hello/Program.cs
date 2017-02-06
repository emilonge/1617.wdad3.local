using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args == null | args.Length == 0)
            {
                Console.WriteLine("Hello World - For Developers Without arguments!");
            }
            else 
            {
                string msg = "";
                for(var i = 0;i<args.Length;i++) 
                {
                    if(i > 0)
                    {
                        msg += " ";
                    }
                    msg += args[i];
                }
                
                Console.WriteLine("Hello World - {0}!", msg);
            }
        }
    }
}
