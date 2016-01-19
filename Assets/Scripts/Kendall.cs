using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class Kendall
    {
        public static int age = 45;

        public void sayYourSay(string what)
        {
            Console.WriteLine(what);
        }
    }

    class Oliver : Kendall
    {
        string whatToSay = "Kendall is amazing";
        int GiveAgeAway()
        {
            sayYourSay(whatToSay);
            return age - 40;
        }
            
    }
}
