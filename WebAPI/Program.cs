using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Services.Abstract;
using Services.Concrete;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
	.AddControllers()
	.AddJsonOptions(i => i.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve)
	.AddOData(
		configuration =>
		{
			configuration.EnableQueryFeatures();
		}
	);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<FinekraContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));

builder.Services.AddTransient<IPerfumeDal, PerfumeDal>();
builder.Services.AddTransient<IPerfumeService, PerfumeManager>();

builder.Services.AddTransient<ILoggerService, LoggerManager>();

builder.Services.AddTransient<IUserDetailDal, UserDetailDal>();
builder.Services.AddTransient<IUserDetailService, UserDetailManager>();

builder.Services.AddTransient<IOrderService, OrderManager>();
builder.Services.AddTransient<IOrderDal, OrderDal>();

builder.Services.AddTransient<IOrderDetailDal, OrderDetailDal>();
builder.Services.AddTransient<IOrderDetailService, OrderDetailManager>();

builder.Services.AddTransient<IBasketDal, BasketDal>();
builder.Services.AddTransient<IBasketService, BasketManager>();

builder.Services.AddTransient<IBasketItemService, BasketItemManager>();
builder.Services.AddTransient<IBasketItemDal, BasketItemDal>();

builder.Services.AddTransient<IBrandService, BrandManager>();
builder.Services.AddTransient<IBrandDal, BrandDal>();


Log.Logger = new LoggerConfiguration()
	.ReadFrom.Configuration(builder.Configuration).CreateLogger();



var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
