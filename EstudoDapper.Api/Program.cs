using EstudoDapper.Api;
using EstudoDapper.Api.Middlewares;
using EstudoDapper.Domain.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
Setup.AddSwaggerServices(builder);
Setup.AddEntityFrameworkServices(builder);
Setup.AddDependencyInjection(builder);
Setup.AddAutoMapperServices(builder);
Setup.AddDapperContext(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
