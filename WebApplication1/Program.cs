using FastEndpoints;
using FastEndpoints.Swagger;
using Adapters.MongoDb.Extensions;
using Domain.Application.Mapping;
using Domain.Application.UserCase;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddFastEndpoints();


builder.Services.AddSwaggerDoc();
builder.Services.AddScoped<IUSCConsultar, UserCaseConsultar>();
builder.Services.AddMongoAdapter();
var app = builder.Build();


app.UseAuthorization();
app.UseFastEndpoints();
app.UseOpenApi(); //add this
app.UseSwaggerUi3(s => s.ConfigureDefaults()); //add this
app.Run();