using AspNetPipelines.Api.Middlewares;
using AspNetPipelines.Middlewares;

// create host
var builder = WebApplication.CreateBuilder(args);

// services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// app creation
var app = builder.Build();

app.UseRefererMiddleware();

// pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMyCustomMiddleware();

app.MapControllers();

app.Run();
