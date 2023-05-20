using System.Text;

using ImXiaoXin.Site.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddBootstrapBlazor();

builder.Configuration.AddJsonFile("./Data/SiteRouteData.json", true, true);
builder.Services.Configure<List<RouteDataConfig>>(builder.Configuration.GetSection("RouteData"));

//builder.Services.AddSingleton<WeatherForecastService>();

// 增加 Table 数据服务操作类
//builder.Services.AddTableDemoDataService();

//builder.Services.AddDbContext<SiteDbContext>(options =>
//  options.UseSqlite(builder.Configuration.GetConnectionString("SiteDbContext")));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    //app.UseMigrationsEndPoint();
}

//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;

//    var context = services.GetRequiredService<SiteDbContext>();
//    context.Database.EnsureCreated();
//}

app.UseStaticFiles();

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();