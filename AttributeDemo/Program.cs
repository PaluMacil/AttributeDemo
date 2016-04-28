using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            Console.WriteLine("Bob (Normal):");
            var testSession1 = new Session();
            testSession1.User = "Bob";
            testSession1.Role = Roles.Normal;
            var accountController1 = new AccountController(testSession1);
            accountController1.ChangePassword();
            var homeController1 = new HomeController(testSession1);
            homeController1.LandingPage();

            //Test 2
            Console.WriteLine("\n\nAlice (Admin):");
            var testSession2 = new Session();
            testSession2.User = "Alice";
            testSession2.Role = Roles.Admin;
            var accountController2 = new AccountController(testSession2);
            accountController2.ChangePassword();
            var homeController2 = new HomeController(testSession2);
            homeController2.LandingPage();

            //Test 3
            Console.WriteLine("\n\nOscar (Anonymous):");
            var testSession3 = new Session();
            testSession3.User = "Oscar";
            testSession3.Role = Roles.Anonymous;
            var accountController3 = new AccountController(testSession3);
            accountController3.ChangePassword();
            var homeController3 = new HomeController(testSession3);
            homeController3.LandingPage();

            Console.ReadKey();
        }
    }
}
