using TestingKwikpikAPI.Data_Access.AuthenticateRepo;
using TestingKwikpikAPI.Data_Access.ConfirmBatchRequestRepo;
using TestingKwikpikAPI.Data_Access.ConfirmSingleRequestRepo;
using TestingKwikpikAPI.Data_Access.CreateBatchRequestRepo;
using TestingKwikpikAPI.Data_Access.CreateSingleRequestRepo;
using TestingKwikpikAPI.Data_Access.GetDispatchRequestRepo;
using TestingKwikpikAPI.Data_Access.HomeRepo;
using TestingKwikpikAPI.Data_Access.WalletRepo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IHomeAPI, HomeAPI>();
builder.Services.AddHttpClient<IAuthenticateAPI, AuthenticateAPI>();
builder.Services.AddHttpClient<IWalletAPI, WalletAPI>();
builder.Services.AddHttpClient<IGetDispatchRequestAPI, GetDispatchRequestAPI>();
builder.Services.AddHttpClient<ICreateSingleRequestAPI, CreateSingleRequestAPI>();
builder.Services.AddHttpClient<ICreateBatchRequestAPI, CreateBatchRequestAPI>();
builder.Services.AddHttpClient<IConfirmSingleRequestAPI, ConfirmSingleRequestAPI>();
builder.Services.AddHttpClient<IConfirmBatchRequestAPI, ConfirmBatchRequestAPI>();

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
