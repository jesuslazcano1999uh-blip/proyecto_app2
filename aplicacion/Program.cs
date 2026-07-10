using aplicacion.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios
builder.Services.AddControllersWithViews();

// Servicios personalizados
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<NotificacionService>();
//Axel Ojeda Gallardo
builder.Services.AddScoped<RecordatorioService>();

var app = builder.Build();

// Configuración del pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 💡 Se agregó esta línea para mapear correctamente los ApiControllers
app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
