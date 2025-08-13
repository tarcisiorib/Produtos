using Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace Infra.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<ProdutosDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
