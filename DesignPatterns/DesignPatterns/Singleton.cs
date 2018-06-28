using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private int _numberOfInstance = 0;
        private static Singleton _instance = new Singleton();

        public static int MyVar = 10;

        public Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
        private Singleton()
        {
            Console.WriteLine("Private ctor");
            _numberOfInstance++;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.MyVar);
        }
    }
}
