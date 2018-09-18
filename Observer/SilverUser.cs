using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class SilverUser : User 
    {
        #region variable decleration

        //private Magazine magazine; inherited from User class
        // private string userName;  inherited from User class
        #endregion


        #region constructor
        //constructor-1
        // SilverUser silverUser = new SilverUser(magazine); UserName eksik
        public SilverUser(Magazine magazine)
        {
            this.magazine = magazine;
            magazine.AddSubscriber(this);
            this.userName = "";
        }
        //constructor-2
        // SilverUser silverUser = new SilverUser(userName,magazine); 
        public SilverUser(string userName, Magazine magazine)
        {
            this.userName = userName;
            this.magazine = magazine;
            magazine.AddSubscriber(this);
        }
        //constructor-3
        // SilverUser silverUser = new SilverUser(userName); Magazine eksik
        public SilverUser(string userName)
        {
            this.userName = userName;
            Console.WriteLine("Do not forget to call SetMagazine()");
        }

        #endregion

        #region setter getter region
        // constructor-3 
        override
        public void SetMagazine(Magazine magazine)
        {
            this.magazine = magazine;
            magazine.AddSubscriber(this);
        }
        // construtor-1
        override
        public void SetUserName(string userName)
        {
            this.userName = userName;
        }
        override
        public string GetUserName()
        {
            return userName;
        }


        #endregion

        #region body
        public override void Update()
        {
            if (this.userName == null)
            {
                Console.WriteLine("User name is not declared");
            }
            else
            {
                Console.WriteLine("Silver User : " + this.userName + " is updated by " + this.magazine.GetMagazineName());
            }
        }




        #endregion
    }
}
