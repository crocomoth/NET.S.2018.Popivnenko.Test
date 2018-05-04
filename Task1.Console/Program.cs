using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task1.Solution.Interface;
using Task1.Solution.Model;
using Task1.Solution.Repository;
using Task1.Solution.Service;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Role = Role.Admin;

            IRepository repository = new SqlRepository();

            IPasswordChecker passwordChecker = new PasswordCheckerSevice(repository);

            var tulpe = passwordChecker.VerifyPassword("abc12345dnek", user);

            System.Console.WriteLine(tulpe.Item2);
            System.Console.ReadLine();
        }
    }
}
