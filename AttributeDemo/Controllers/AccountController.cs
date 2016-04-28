using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [Authorize(Roles.Normal, Roles.Admin)]
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
