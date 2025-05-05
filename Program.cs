var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // ✅ This is what serves CSS, JS, images, etc.

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages(); // ✅ No need for .WithStaticAssets()

app.Run();
