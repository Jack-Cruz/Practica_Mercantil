using Microsoft.EntityFrameworkCore;
using Practica_Mercantil.Models;
using Practica_Mercantil.Services;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllers();
builder.Services.AddTransient<JsonFileWorkerService>();
builder.Services.AddDbContext<MercantilContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DemoTrabajadores")));

// builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<MercantilContext>();
    // context.Database.EnsureCreated();
    // DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapBlazorHub();
//app.MapGet("/products", (context) =>
//{
//    var workers = app.Services.GetService<JsonFileWorkerService>().GetWorkers();
//    var json = JsonSerializer.Serialize<IEnumerable<Worker>>(workers);
//    return context.Response.WriteAsync(json);
//}); 


app.Run();
