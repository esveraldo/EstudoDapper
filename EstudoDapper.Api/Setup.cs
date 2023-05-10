using EstudoDapper.Application.Interfaces;
using EstudoDapper.Application.Services;
using EstudoDapper.Domain.Interfaces;
using EstudoDapper.Infraesturcture.Data.Contexts;
using EstudoDapper.Infraesturcture.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EstudoDapper.Api
{
    public static class Setup
    {
        public static void AddSwaggerServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
        }

        public static void AddEntityFrameworkServices(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("EstudoDapper");
            builder.Services.AddDbContext<EntityFrameworkContext>(options => options.UseSqlServer(connectionString));
        }

        public static void AddDependencyInjection(this WebApplicationBuilder builder)
        {
            //Serviços
            builder.Services.AddTransient<IClienteAppService, ClienteAppService>();

            //Repositorios
            builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
            builder.Services.AddTransient<IConjugeRepository, ConjugeRepository>();
            builder.Services.AddTransient<IImovelRepository, ImovelRepository>();
            builder.Services.AddTransient<IPessoaFisicaRepository, PessoaFisicaRepository>();
            builder.Services.AddTransient<IPessoaJuridicaRepository, PessoaJuridicaRepository>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        public static void AddAutoMapperServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void AddDapperContext(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<DapperContext>();
        }
    }
}
