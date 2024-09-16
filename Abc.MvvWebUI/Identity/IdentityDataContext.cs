using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext(): base("dataConnection")
        {

        }
        public static IdentityDataContext Create()
        {
            return new IdentityDataContext();
        }
    }
}