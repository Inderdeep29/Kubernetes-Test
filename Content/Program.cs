using Microsoft.EntityFrameworkCore;
using Content.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<TodoContext>(opt =>
//    opt.UseInMemoryDatabase("TodoList"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
  options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"))
    .UseSnakeCaseNamingConvention()
  );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DataContext>();
    context.Database.EnsureCreated();
    // DbInitializer.Initialize(context);
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
