using API.Repository;
using Database.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<DatabaseContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#region Database Setup
using (var context = new DatabaseContext())
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    DatabaseContext.CreateData(context);
}
#endregion

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
