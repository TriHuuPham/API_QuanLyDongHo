using API_DesignPartern.Data;
using API_DesignPartern.Repositories.DongHoRepositories;
using API_DesignPartern.Services.DongHoService;
using API_QLDongHo_DesignPartern.Repositories.NhaCungCapRepositories;
using API_QLDongHo_DesignPartern.Services.NhaCungCapService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




// ------------------------------ Cấu hình kết nối đến cơ sở dữ liệu ------------------------------
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



// ------------------------------ Đăng ký các dịch vụ của ứng dụng ------------------------------
builder.Services.AddScoped<IDongHoServices, DongHoServices>();
builder.Services.AddScoped<IDongHoRepository, DongHoRepository>();
builder.Services.AddScoped<INhaCungCapRepository, NhaCungCapRepository>();
builder.Services.AddScoped<INhaCungCapServices, NhaCungCapServices>();





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
