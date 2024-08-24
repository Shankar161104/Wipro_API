using Microsoft.EntityFrameworkCore;
using Wipro_API_Customer_Service_Model.EntityFramework;
using Wipro_API_Customer_Service_Model.Repository;





var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(tm => tm.UseSqlServer(builder.Configuration.GetConnectionString("CustomerConnection")));
builder.Services.AddTransient<ICustomerService,CustomerService>();




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
