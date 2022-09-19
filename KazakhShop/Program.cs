using KzShop.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSession();

var app = builder.Build();

app.MapGet("/", () => "Murk Murk!");
app.MapGet("/Product/", () => new ProductController().Index());
app.MapGet("/Product/GetAll", () => new ProductController().GetAll());
app.Run();
