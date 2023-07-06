using DiningVsCodeNew;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var emailConfig = builder.Configuration
        .GetSection("EmailConfiguration")
        .Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);
builder.Services.AddControllers();
builder.Services.AddScoped<IEmailSender, EmailSender>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Configuration
 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
 .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true);     
 builder.Services.Configure<Setting>(builder.Configuration.GetSection("Setting"));
 var setting=builder.Configuration.GetSection("Setting").Get<Setting>();
 builder.Services.AddSingleton<Setting>(setting);
 Setting.initializeRepoDb();
 builder.Services.AddSingleton<UserRepository>();
 builder.Services.AddSingleton<MenuRepository>();
 builder.Services.AddSingleton<VoucherRepository>();
 builder.Services.AddSingleton<CustomerTypeRepository>();
 builder.Services.AddSingleton<PaymentMainRepository>();
 builder.Services.AddSingleton<PaymentDetailsRepository>();
 builder.Services.AddSingleton<MenuRepository>(); 
 builder.Services.AddSingleton<PaymentModeRepository>();
 builder.Services.AddSingleton<OrderedMealRepository>();
 builder.Services.AddSingleton<OnlinePaymentRepository>();
 builder.Services.AddSingleton<ServedRepository>();
var app = builder.Build();
// var app = builder.Build();
app.UseCors(option=>option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
