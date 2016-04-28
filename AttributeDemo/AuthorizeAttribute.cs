using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorizeAttribute : Attribute
    {
        public Roles[] allowedRoles { get; set; }

        public AuthorizeAttribute(Roles[] r)
        {
            allowedRoles = r;
        }
    }
}
