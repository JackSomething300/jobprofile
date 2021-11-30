using JOBProfile;
using JOBProfile.Core.Repositories;
using JOBProfile.Infrastructure.Data;
using JOBProfile.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IRecipiesRepository, RecipiesRepository>();
var app = builder.Build();

app.MapControllerRoute(
    pattern: "{controller=Home}/{action=Index}/{id?}",
    name: "default"
    );

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.Run();
