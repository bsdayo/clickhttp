using Microsoft.Extensions.FileProviders;

var app = WebApplication.Create(args);

app.Environment.WebRootFileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapFallback(() => Results.Redirect("/index.html"));

app.Run();