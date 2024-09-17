using PMS.Application;
using PMS.Infrastracture;
using PMS.Presistance;

var builder = WebApplication.CreateBuilder(args);

#region Service Resigtration
builder.Services.AddControllersWithViews();

// Registering Appilcation layer 
builder.Services.AddApplication();
builder.Services.AddPresistance();
builder.Services.AddInfrastracture();
#endregion

var app = builder.Build();

#region Middleware Pipeline Setup

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Dashboard/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

#endregion

app.Run();
