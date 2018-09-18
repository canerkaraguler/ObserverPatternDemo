using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine("fintech");

            User goldUser1 = new GoldUser("goldUser1");
            goldUser1.SetMagazine(magazine);

            User goldUser2 = new GoldUser(magazine);
            goldUser2.SetUserName("goldUser2");

            User silverUser1 = new SilverUser("silverUser1", magazine);
            User silverUser2 = new SilverUser("silverUser2", magazine);

            User bronzeUser1 = new BronzeUser("bronzeUser1", magazine);
            User bronzeUser2 = new BronzeUser("bronzeUser2", magazine);


            Console.WriteLine("-------------------------------------");

            magazine.ChangeState(States.PRINT);
            Console.WriteLine("-------------------------------------");
            magazine.ChangeState(States.PUBLISH);



            Console.ReadKey();
        }
    }
}
