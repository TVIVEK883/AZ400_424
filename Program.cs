var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // enable serving HTML/CSS/JS

app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();
