using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("Ecommerce", new OpenApiInfo { Title = "Ecommerce API v1", Version = "v1" });
    c.SwaggerDoc("Admin", new OpenApiInfo { Title = "Admin API v1", Version = "v1" });
});

var app = builder.Build();

// 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/Ecommerce/swagger.json", "Ecommerce API v1");
        options.SwaggerEndpoint("/swagger/Admin/swagger.json", "Admin API v1");
    });

    app.UseCors("AllowSpecificOrigin"); // Sử dụng CORS
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
