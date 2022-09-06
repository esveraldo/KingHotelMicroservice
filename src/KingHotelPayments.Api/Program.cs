using KingHotelPayments.Api.Services.Implementations;
using KingHotelPayments.Api.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("KingHotel",
        builder => builder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()
        .WithMethods("GET", "PUT", "DELETE", "POST", "PATCH") //not really necessary when AllowAnyMethods is used.
        );
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("KingHotel");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
