using Microsoft.AspNet.Identity.EntityFramework;
using Fluent.Infrastructure.FluentModel;

namespace TreinamentoDotNet.Database
{
    public class AuthDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthDbContext() : base("DbConnection", throwIfV1Schema: false)
        {
        }

        public static AuthDbContext Create()
        {
            return new AuthDbContext();
        }
    }
}
