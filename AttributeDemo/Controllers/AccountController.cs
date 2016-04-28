using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{//new int [] { 0, 0, 0 };
    [Authorize(new Roles[] {Roles.Normal, Roles.Admin})]
    public class AccountController : Controller
    {
        public AccountController(Session context)
            :base(context)
        {
            //
        }

        public void ChangePassword()
        {
            Console.WriteLine("Password changed!");
        }
    }
}
