//using Introduction;
//using Introduction.Extensions;
//using Introduction.Services;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();

//builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();

////builder.Services.AddCors((cors) =>
////{
////    cors.AddPolicy("AllowLocalhost4200", policy =>
////    {
////        policy.WithOrigins("http://localhost:4200/").AllowAnyHeader().AllowAnyMethod();
////    });
////});
//builder.Services.AddCors((cors) =>
//{
//    cors.AddPolicy("AllowLocalhost4200", policy =>
//    {
//        policy.
//        WithOrigins("http://localhost:4200").
//        AllowAnyHeader().
//        AllowAnyMethod();
//    });
//});



//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}


//app.UseCors("AllowLocalhost4200");

////To use the middleware, should register here

////app.UseMiddleware<HTTPContextMiddleware>();

////app.UseHttpContextDemo();

////app.UseLoggingContextDemo();


//app.UseJWTAuthenticationDemo();

//app.UseAuthenticationDemo();

//app.UseHttpsRedirection();


//app.UseAuthorization();

//app.MapControllers();

//app.Run();


using Introduction;
using Introduction.Extensions;
using Introduction.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();
builder.Services.AddSingleton<IJWTAuthenticationService, JWTAuthenticationService>();








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

//http://localhost:4200

//https://localhost:7115/api/Employees/GetEmpName

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseCors("AllowLocalhost4200");


//'afadafsdfadfasdsfdasdasdasd';


//Multiple middlewares in future
//app.UseMiddleware<HTTPContextMiddleware>();
//logging
//excption
//autthenication
//app.UseHttpContextDemo();
//app.UseLoggingContextDemo();


//app.UseAuthentictionDemo();
app.UseJWTAuthenticationDemo();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();