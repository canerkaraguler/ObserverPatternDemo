using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Magazine
    {
        #region variables
        private string magazineName;
        private List<User> userList;
        private States state;

        #endregion

        #region constructor
        public Magazine(string magazineName)
        {
            this.userList = new List<User>();
            this.magazineName = magazineName;
            this.state = States.DESIGN;
        }

        #endregion


        #region setter-getter

        public void ChangeState(States state)
        {
            if(state == States.DESIGN)
            {
                Console.WriteLine("State chaged to "+state.ToString());
            }else if (state == States.PRINT)
            {
                Console.WriteLine("State chaged to " + state.ToString());
            }
            else
            {
                Console.WriteLine("State chaged to " + state.ToString());
                NotifyUsers();

            }
        }

        public void NotifyUsers()
        {
            foreach(User user in userList)
            {
                user.Update();
            }
        }
        public string GetMagazineName()
        {
            return magazineName;
        }





        #endregion



        #region body
        // option-1: 
        //User goldUser = new GoldUser(magazine); constructor içerisinde AddSubscriber methodunun çağırıldığı varsayıldığında

        /*
         *option-2:
         * User goldUser = new GoldUser(userName);
         * goldUser.SetMagazine(magazine); SetMagazine içerisinde AddSubscriber methodunun çağırıldığı varsayıldığında
         * 
         * */

        //option-2:
        //User goldUser = new GoldUser(userName);
        //magazine.AddSubscriber(goldUser) Hiçbir şekilde user içinden AddSubscriber methodunun çağırılmadığında

        public void AddSubscriber(User user)
        {
            userList.Add(user);
            Console.WriteLine(user.GetUserName()+" is subscribed !!");
        }



        #endregion




    }
}
