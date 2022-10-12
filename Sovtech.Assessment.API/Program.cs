using Microsoft.AspNetCore.Cors;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

 string CORS_POLICY = "CorsPolicy";


//
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CORS_POLICY,
                      policy =>
                      {
                          policy.WithOrigins("*").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); ;
                      });
});


builder.Services.AddSwaggerGen(s =>
{
   s.SwaggerDoc("v1", new OpenApiInfo()
   {
       Version = "v1",
       Title = "Swagger Api for the Sovtech Assessment Application",
       Description = $"This apllication is served by machine number - {Environment.MachineName}"
   });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "SovTech Chuck/Swapi/Search API");
            });
    
}


app.UseCors(CORS_POLICY);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
