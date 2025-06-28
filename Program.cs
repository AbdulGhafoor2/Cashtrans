using Cashtrans.DataAccessLayer.Interface;
using Cashtrans.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Program.cs or Startup.cs (depending on .NET version)
//builder.Services.AddHttpClient<IDispatchLockService, DispatchLockService>(client =>
//{
//    client.BaseAddress = new Uri("https://example.com/"); // <- Replace with real API base URL
//});

builder.Services.AddHttpClient<IDispatchLockService, DispatchLockService>();

builder.Services.AddHttpClient<ICloseLockService, CloseLockService>();
builder.Services.AddHttpClient<IReadLockDataService, ReadLockDataService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
