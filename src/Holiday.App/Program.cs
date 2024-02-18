using Holiday.App.Application;
using Holiday.App.Application.Commands;
using Holiday.App.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Holiday.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddApplication(builder.Configuration);
            builder.Services.AddInfrastructure(builder.Configuration);

            builder.Services.AddAuthorization();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapPost("/holidays", async (QueryHolidayCommand queryHolidayCommand, [FromServices] IMediator mediator) =>
            {
                var response = await mediator.Send(queryHolidayCommand);
                return response;
            })
            .WithName("holidays")
            .WithOpenApi();

            app.Run();
        }
    }
}
