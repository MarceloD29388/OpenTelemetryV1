using Microsoft.EntityFrameworkCore;
using Curso.Context;
using Serilog;
using Curso.Producer;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

//Agrego el servicio de Log.
var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

//Agrego OpenTelemetry 
builder.Services.AddOpenTelemetry()
    .WithTracing(tracerProviderBuilder =>
        tracerProviderBuilder
        .AddOtlpExporter(opt =>
        {
            opt.Endpoint = new Uri("https://localhost:4317");
        })
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddJaegerExporter()
        
);


builder.Services.AddControllers();
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//OpenTelemetry
builder.Services.AddHttpClient();
builder.Services.AddRazorPages();

// KAFKA
builder.Services.AddScoped<IProducer, KafkaProducer>();
builder.Services.AddSingleton<KafkaOptions>();

var app = builder.Build();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
