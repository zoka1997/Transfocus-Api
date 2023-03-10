using Microsoft.EntityFrameworkCore;
using Transfocus.POD.BusinessLogic.BusinessObjects.Panel.NewEnquiry;
//using TransfocusBack.DataContext;
using TransfocusBack.DBData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<transfocusqa20229261212Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TransFocus")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(optipons =>
{
    optipons.AddPolicy("AllowAll",
        policy => policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
