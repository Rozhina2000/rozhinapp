
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Minimal API + static files
var app = builder.Build();

app.UseDefaultFiles();   // serves index.html automatically
app.UseStaticFiles();

// Simple endpoints
app.MapGet("/api", () => Results.Ok(new { message = "Hello from RozhinApp (.NET 8 minimal API)!" }));
app.MapGet("/api/ping", () => Results.Ok(new { status = "ok", app = "RozhinApp" }));
app.MapGet("/api/time", () => Results.Ok(new { utc = DateTime.UtcNow }));

app.Run();
