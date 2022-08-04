using NetCore6;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthentication();
builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();
builder.Services.AddRazorPages().AddRazorPagesOptions(options => {
    options.RootDirectory = "/Pages";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

//app.AddRazorPages();
/*
app.Map("/", async context =>
{
    var html = HtmlHelper.HtmlDocument("Hello", "Hello World!".HtmlTag("h1", "text-danger"));
    await context.Response.WriteAsync(html);
});
*/
app.MapGet("/", () => "Hello World!");

app.UseEndpoints(endpoints =>
    {
        // Thêm endpoint chuyển đến các trang Razor Page
        // trong thư mục Pages
        endpoints.MapRazorPages();
        
    });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
