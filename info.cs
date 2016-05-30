// Get user info
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info
{
    class Get
    {
        static void Main(string[] args)
        {

        
        }
        
        public void name()
        {
        Console.WriteLine("What is your name?");
        string user_name = Console.ReadLine();
        }
        
        public void pob() 
        {
         Console.WriteLine("And where are you from?");
        string pob = Console.ReadLine();
        }

        public void age() 
        {
        Console.WriteLine("And how old are you?");
        string age_str = Console.ReadLine();
        }
    }
}
