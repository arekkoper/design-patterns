using DesignPatterns.Application;
using DesignPatterns.Application.FactoryMethod;
using DesignPatterns.Application.FactoryMethod.Abstraction;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IPatternLoader, PatternLoaderService>(provider =>
{
    var loader = new PatternLoaderService();
    loader.Load();
    return loader;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "pattern",
        pattern: "Home/Pattern/{name}",
        defaults: new { controller = "Home", action = "Pattern" });
});


app.Run();
