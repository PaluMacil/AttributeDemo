using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    public class Controller
    {
        Session Context { get; set; }

        public Controller(Session context)
        {
            Roles[] allowedRoles = null;
            var attribs = GetType().GetCustomAttributes(false);
            foreach (var attrib in attribs)
            {
                if (attrib is AuthorizeAttribute)
                {
                    allowedRoles = ((AuthorizeAttribute)attrib).allowedRoles;
                }
            }
            if (allowedRoles != null && !allowedRoles.Contains(context.Role))
            {
                Console.WriteLine("Redirect! No access permitted!");
            }
            else
            {
                Console.WriteLine("Allowed.");
            }
        }
    }
}
