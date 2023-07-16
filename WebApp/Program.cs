using AspNetStatic;
using AspNetStatic.Models;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.PageViewLocationFormats.Add("~/Pages/Partials/{0}" + RazorViewEngine.ViewExtension);
});
builder.Services.AddSingleton<IStaticPagesInfoProvider>(
    new StaticPagesInfoProvider(
        new PageInfo[]
        {
            new("/Index"),
            new("/Posts/Sirowa"),
        }
    ));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.GenerateStaticPages(
    new GenerateStaticPagesOptions()
    {
        DestinationRoot = GenerateStaticPagesOptions.ParseOptions(args, app.Environment.WebRootPath).DestinationRoot,
        DontOptimizeContent = true
    }
);
app.Run();