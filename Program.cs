using API_DesignPartern.Data;
using API_DesignPartern.Repositories.DongHoRepositories;
using API_DesignPartern.Services.DongHoService;
using API_QLDongHo_DesignPartern.Repositories.NhaCungCapRepositories;
using API_QLDongHo_DesignPartern.Repositories.PhanLoaiRepositories;
using API_QLDongHo_DesignPartern.Repositories.ThuongHieuRepositories;
using API_QLDongHo_DesignPartern.Services.NhaCungCapService;
using API_QLDongHo_DesignPartern.Services.PhanLoaiService;
using API_QLDongHo_DesignPartern.Services.ThuongHieuService;
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
// ------------------------ Services ------------------------
builder.Services.AddScoped<IDongHoServices, DongHoServices>();
builder.Services.AddScoped<INhaCungCapServices, NhaCungCapServices>();
builder.Services.AddScoped<IPhanLoaiServices, PhanLoaiServices>();
builder.Services.AddScoped<IThuongHieuServices, ThuongHieuServices>();

// ------------------------ Repository ------------------------
builder.Services.AddScoped<IDongHoRepository, DongHoRepository>();
builder.Services.AddScoped<INhaCungCapRepository, NhaCungCapRepository>();
builder.Services.AddScoped<IThuongHieuRepository, ThuongHieuRepository>();
builder.Services.AddScoped<IPhanLoaiRepository, PhanLoaiRepository>();




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
