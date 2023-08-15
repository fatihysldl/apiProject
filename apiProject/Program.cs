using apiProject.BusinessLayer.concrete;
using apiProject.DataAccessLayer.concrete;
using apiProject.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<context>();
builder.Services.AddScoped<IToDoListDal, EfToDoListDal>();
builder.Services.AddScoped<IToDoListService, toDoListManager>();

builder.Services.AddCors(Opt =>
{
    Opt.AddPolicy("apiCors", Opt =>
    {
        Opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("apiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
