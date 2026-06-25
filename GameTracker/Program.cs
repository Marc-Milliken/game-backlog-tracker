using GameTracker.Data;
using GameTracker.Services;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<GameContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GameContext")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// Register our GameService as a Singleton
// Singleton means only ONE instance is created and shared by everyone
// This keeps our in-memory game list consistent across all requests
builder.Services.AddScoped<GameService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<GameContext>();
    context.Database.EnsureCreated();

    var gameService = services.GetRequiredService<GameService>();
    DbInitializer.Initialize(context, gameService);
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
