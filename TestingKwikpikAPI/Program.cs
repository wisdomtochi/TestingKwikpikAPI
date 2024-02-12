using TestingKwikpikAPI.Application.Implementation;
using TestingKwikpikAPI.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<IHomeAPI, HomeAPI>();
builder.Services.AddHttpClient<IAuthenticateAPI, AuthenticateAPI>();
builder.Services.AddHttpClient<IWalletAPI, WalletAPI>();
builder.Services.AddHttpClient<IGetDispatchRequestAPI, GetDispatchRequestAPI>();
builder.Services.AddHttpClient<IDispatchRequestAPI, DispatchRequestAPI>();
builder.Services.AddHttpClient<IBatchRequestAPI, BatchRequestAPI>();
builder.Services.AddHttpClient<IRequestConfirmationAPI, CreateDispatchRequestAPI>();
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
