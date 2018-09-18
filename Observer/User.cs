using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class User
    {
        protected Magazine magazine;
        protected string userName;

        public abstract void Update();
        public abstract string GetUserName();
        public abstract void SetMagazine(Magazine magazine);
        public abstract void SetUserName(string userName);
    }
}
