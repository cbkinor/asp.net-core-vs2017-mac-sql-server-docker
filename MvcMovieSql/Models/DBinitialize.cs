using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MvcMovieSql.Models
{
	public static class DBinitialize
	{
		public static void EnsureCreated(IServiceProvider serviceProvider)
		{
			var context = new MvcMovieSqlContext(
				serviceProvider.GetRequiredService<DbContextOptions<MvcMovieSqlContext>>());
			context.Database.EnsureCreated();
		}
	}
}
