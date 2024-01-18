using Microsoft.EntityFrameworkCore;
using NLog.Web;
using ReportService;
using ReportService.Helpers;
using ReportService.Repositories;
using ReportService.Repositories.Interfaces;
using ReportService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();

builder.Logging.SetMinimumLevel(LogLevel.Debug);
builder.Host.UseNLog(new NLogAspNetCoreOptions() { RemoveLoggerFactoryFilter = true });

builder.Services.AddMemoryCache();
builder.Services.AddDbContextPool<ApplicationDbContext>(optionsAction: opt =>
{
    opt.UseMySql(builder.Configuration.GetConnectionString("MariaDB"), new MySqlServerVersion(new Version(10, 11, 16)));
});

// Register Singleton service
builder.Services.AddSingleton<AppLogger>();
builder.Services.AddSingleton<ICacheRepository, CacheRepository>();

// Register Scoped service
builder.Services.AddScoped<IFileHistoryRepository, FileHistoryRepository>();
builder.Services.AddScoped<IHistoryRepository, HistoryRepository>();
builder.Services.AddScoped<IBKPFRepository, BKPFRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Register Hosted Service
builder.Services.AddHostedService<PopulateFileService>();
builder.Services.AddHostedService<PopulateBSEGQueueService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
