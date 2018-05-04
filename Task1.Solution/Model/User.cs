using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Solution.Model
{
    public class User
    {
        private string _password;
        private Role _role;

        public Role Role { get => _role; set => _role = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
