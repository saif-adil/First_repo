
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using WebApiTulgberk.Domain.Entities;


[assembly: InternalsVisibleTo("WebApiTulgberk.Api.Host")]
namespace WebApiTulgberk.Domain.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WebApiTulgberk.Domain.EntitiesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiTulgberk.Domain.EntitiesContext context)
        {
            context.Roles.AddOrUpdate(role => role.Name,
             new Role { Key = Guid.NewGuid(), Name = "Admin" },
             new Role { Key = Guid.NewGuid(), Name = "Employee" },
             new Role { Key = Guid.NewGuid(), Name = "Affiliate" }
             );
        }
    }
}
