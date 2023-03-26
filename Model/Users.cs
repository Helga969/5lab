using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lab.Model
{
    class Users
    {
        public int IdUsers { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Users() { }
        public Users(int id, string lgn, string psw)
        {
            IdUsers = id;
            Login = lgn;
            Password = psw;
        }
    }
}
