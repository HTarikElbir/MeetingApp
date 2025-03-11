var builder = WebApplication.CreateBuilder(args);

//For mvc
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Meeting}/{action=Index}/{id?}");

app.Run();
