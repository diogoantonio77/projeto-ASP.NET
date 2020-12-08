using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Loja.Web.Identity
{
    public class ProductEntityDbContext : IdentityDbContext<IdentityUser>
    {
        public ProductIdentityDbContext ()
            :base("ProductDbContext")
        {

        }
    }
}