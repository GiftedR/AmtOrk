using AmtOrk.Server.Data;
using AmtOrk.Server.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server
{
	public class Program
	{
		public static string ConnectionString { get; private set; } = "";

		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			
			// ConnectionString = builder.Configuration.GetConnectionString("LiteDB") ??
			// 	throw new InvalidOperationException("Connection String Not Found");
			builder.Services.AddScoped<AmtOrkContext>();
			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			app.UseDefaultFiles();
			app.UseStaticFiles();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.MapFallbackToFile("/index.html");

			app.Run();
		}
	}
}
