using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkListMaker.model.Context
{
	public class MyDbContext : DbContext
	{
		public MyDbContext() : base("name=MyDbContext") { }

		public DbSet<Employee> Employees { get; set;}
		public DbSet<PolyclinicArea> PolyclinicAreas { get; set; }
	}
}
