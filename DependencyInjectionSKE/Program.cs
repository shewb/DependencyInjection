using DependencyInjectionSKE.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ISingletonOperation, SingletonOperation>();
builder.Services.AddTransient<ITransientOperation, TransientOperation>();
builder.Services.AddScoped<IScopedOperation, ScopedOperation>();

builder.Services.AddTransient<IMyService, MyService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
