using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Kubernetes;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

//builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
//    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
//    .AddEnvironmentVariables();
builder.Services.AddOcelot(builder.Configuration).AddKubernetes();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());
app.UseOcelot().Wait();

app.Run();