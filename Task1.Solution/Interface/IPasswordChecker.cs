using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution.Model;

namespace Task1.Solution.Interface
{
    public interface IPasswordChecker
    {
        Tuple<bool, string> VerifyPassword(string password, User user);
    }
}
