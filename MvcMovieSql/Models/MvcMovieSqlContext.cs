using System;
using Microsoft.EntityFrameworkCore;

namespace MvcMovieSql.Models
{
	public class MvcMovieSqlContext : DbContext
	{
		public MvcMovieSqlContext(DbContextOptions<MvcMovieSqlContext> options)
			: base(options)
		{
		}

		public DbSet<MvcMovieSql.Models.Movie> Movie { get; set; }
	}
}
