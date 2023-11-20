using System.Text;
using API.Data;
using API.Extensions;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddAIdentityServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable CORS in the middleware 
app.UseCors(builder => builder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins("https://localhost:4200"));

app.UseAuthentication(); // Do you have a valid token?
app.UseAuthorization(); // Valid token validated, what are you allowed to do?

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
