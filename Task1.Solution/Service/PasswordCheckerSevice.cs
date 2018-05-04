using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution.Interface;
using Task1.Solution.Model;

namespace Task1.Solution.Service
{
    public class PasswordCheckerSevice : IPasswordChecker
    {
        private IRepository repository;

        public PasswordCheckerSevice(IRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Tuple<bool, string> VerifyPassword(string password, User user)
        {
            // user will be created after password creation
            // for it is only a placeholder (no password etc. but already has a Role
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (password == null)
                throw new ArgumentNullException(nameof(password));

            if (password == string.Empty)
                return Tuple.Create(false, $"{nameof(password)} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return Tuple.Create(false, $"{nameof(password)} length too short");

            if (user.Role == Role.Admin)
            {
                if (password.Length <= 10)
                {
                    return Tuple.Create(false, $"{nameof(password)} length too short for admin");
                }
            }

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");

            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");

            repository.Create(password);

            user.Password = password;

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
