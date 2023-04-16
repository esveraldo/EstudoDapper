using EstudoDapper.Domain.Entities;
using EstudoDapper.Infraesturcture.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EstudoDapper.Infraesturcture.Data.Contexts
{
    public class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext(DbContextOptions<EntityFrameworkContext> options) : base(options){}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Imovel> Imovels { get; set; }  
        public DbSet<PessoaFisica> PessoaFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridicas { get; set; }
        public DbSet<Conjuge> Conjuge { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ImovelMap());
            modelBuilder.ApplyConfiguration(new PessoaFisicaMap());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaMap());
            modelBuilder.ApplyConfiguration(new ConjugeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
