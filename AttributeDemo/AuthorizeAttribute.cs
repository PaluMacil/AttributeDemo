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
        public Roles[] AllowedRoles { get; set; }

        public AuthorizeAttribute(params Roles[] r)
        {
            AllowedRoles = r;
        }
    }
}
