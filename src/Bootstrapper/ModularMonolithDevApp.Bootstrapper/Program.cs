using ModularMonolithDevApp.Modules.Confrences.Api;
using ModularMonolithDevApp.Shared.Infrastructure;

namespace ModularMonolithDevApp.Bootstrapper;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddConfrencesModule();
        builder.Services.AddInfrastructure();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.MapGet("/", () => "Hello, ME!");
        app.MapControllers();

        app.Run();
    }
}
