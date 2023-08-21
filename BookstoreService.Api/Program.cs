using Bookstore.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

RegisterService(services: builder.Services);

var app = builder.Build();

void RegisterService(IServiceCollection services)
{
    services.AddDatabaseConfiguration(configuration: builder.Configuration);

    services.AddControllers();

    services.AddEndpointsApiExplorer();

    services.AddSwaggerGen();
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
