using ASP.NetEmpty.Services;

namespace ASP.NetEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Đăng ký các dịch vụ với DI Container
            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseHttpsRedirection();  // Middleware chuyển hướng HTTP sang HTTPS

            app.UseStaticFiles();  // Middleware phục vụ các tệp tĩnh từ thư mục wwwroot

            app.UseRouting();  // Middleware xử lý định tuyến

            app.UseAuthorization();  // Middleware xử lý ủy quyền

            app.Run();
        }
    }
}
