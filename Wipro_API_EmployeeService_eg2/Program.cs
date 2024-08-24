using Microsoft.EntityFrameworkCore;
using Wipro_API_EmployeeService_eg2.EntityFramework;
using Wipro_API_EmployeeService_eg2.Repository;




var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeConnection")));
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
