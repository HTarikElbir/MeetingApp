var builder = WebApplication.CreateBuilder(args);

//For mvc
builder.Services.AddControllersWithViews();// Add MVC services to the services container

var app = builder.Build();

app.UseStaticFiles(); // For the wwwroot folder

app.UseRouting(); // For routing

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
    