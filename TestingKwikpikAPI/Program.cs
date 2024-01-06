using TestingKwikpikAPI.DTOs.AuthenticateDTO;
using TestingKwikpikAPI.DTOs.HomeDTO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IHomeAPI, HomeAPI>();
builder.Services.AddScoped<IAuthenticateAPI, AuthenticateAPI>();
builder.Services.AddHttpClient<IHomeAPI, HomeAPI>();
builder.Services.AddHttpClient<IAuthenticateAPI, AuthenticateAPI>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
