using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EstudoDapper.Infraesturcture.Data.Contexts
{
    public class EntityFrameworkContextMigration : IDesignTimeDbContextFactory<EntityFrameworkContext>
    {
        public EntityFrameworkContext CreateDbContext(string[] args)
        {
            #region Localizar o arquivo appsettings.json

            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            #endregion

            #region Capturar a connectionstring do arquivo appsettings.json

            var root = configurationBuilder.Build();
            var connectionString = root.GetSection("ConnectionStrings").GetSection("EstudoDapper").Value;

            #endregion

            #region Fazer a injeção de dependência na classe EntityFrameworkContext

            var builder = new DbContextOptionsBuilder<EntityFrameworkContext>();
            builder.UseSqlServer(connectionString);

            return new EntityFrameworkContext(builder.Options);

            #endregion
        }
    }
}
