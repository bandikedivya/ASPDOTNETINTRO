var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddCors((cors) =>
//{
//    cors.AddPolicy("AllowLocalhost4200", policy =>
//    {
//        policy.WithOrigins("http://localhost:4200/").AllowAnyHeader().AllowAnyMethod();
//    });
//});
builder.Services.AddCors((cors) =>
{
    cors.AddPolicy("AllowLocalhost4200", policy =>
    {
        policy.
        WithOrigins("http://localhost:4200").
        AllowAnyHeader().
        AllowAnyMethod();
    });
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowLocalhost4200");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
