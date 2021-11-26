using JOBProfile.API;
using JOBProfile.Core.Repositories;
using JOBProfile.Infrastructure.Data;
using JOBProfile.Infrastructure.Repositories;
using JOBProfile.Infrastructure.Repositories.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<RecipiesContext>();
        //                    context.Database.Migrate();
        context.Database.EnsureCreated();
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IRecipiesRepository, RecipiesRepository>();
builder.Services.AddAutoMapper(typeof(Startup));
builder.Services.AddMediatR(typeof(CreateEmployeeHandler).GetTypeInfo().Assembly);

app.Run();
