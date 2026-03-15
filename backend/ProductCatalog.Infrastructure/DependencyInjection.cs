using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductCatalog.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection {
	public static void AddInfrastructureServices(this IServiceCollection service, IConfiguration config) {

		service.AddDbContext<AppDbContext>((sp, options) =>
		{
			options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
		});
	}
}