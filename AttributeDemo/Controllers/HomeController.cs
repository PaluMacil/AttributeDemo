using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [Authorize(Roles.Anonymous, Roles.Normal, Roles.Admin)]
    public class HomeController : Controller
    {
        public HomeController(Session context)
            : base(context)
        {
            //
        }

        public void LandingPage()
        {
            Console.WriteLine("Thanks for visiting!");
        }
    }
}
