var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();

var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=User}/{action=index}/{id?}");

app.Run();
