using TestingKwikpikAPI.Data_Access.AuthenticateRepo;
using TestingKwikpikAPI.Data_Access.CreateDispatchRequestRepo;
using TestingKwikpikAPI.Data_Access.HomeRepo;
using TestingKwikpikAPI.Data_Access.WalletRepo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IHomeAPI, HomeAPI>();
builder.Services.AddHttpClient<IAuthenticateAPI, AuthenticateAPI>();
builder.Services.AddHttpClient<IWalletAPI, WalletAPI>();
builder.Services.AddHttpClient<ICreateDispatchRequestAPI, CreateDispatchRequestAPI>();

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
