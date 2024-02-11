using TestingKwikpikAPI.Application.AuthenticateRepo;
using TestingKwikpikAPI.Application.BatchRequestConfirmationRepo;
using TestingKwikpikAPI.Application.BatchRequestRepo;
using TestingKwikpikAPI.Application.ConfirmSingleRequestRepo;
using TestingKwikpikAPI.Application.CreateSingleRequestRepo;
using TestingKwikpikAPI.Application.GetDispatchRequestRepo;
using TestingKwikpikAPI.Application.HomeRepo;
using TestingKwikpikAPI.Application.WalletRepo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IHomeAPI, HomeAPI>();
builder.Services.AddHttpClient<IAuthenticateAPI, AuthenticateAPI>();
builder.Services.AddHttpClient<IWalletAPI, WalletAPI>();
builder.Services.AddHttpClient<IGetDispatchRequestAPI, GetDispatchRequestAPI>();
builder.Services.AddHttpClient<ICreateSingleRequestAPI, CreateSingleRequestAPI>();
builder.Services.AddHttpClient<IBatchRequestAPI, BatchRequestAPI>();
builder.Services.AddHttpClient<IConfirmSingleRequestAPI, ConfirmSingleRequestAPI>();
builder.Services.AddHttpClient<IBatchRequestConfirmationAPI, BatchRequestConfirmationAPI>();

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
