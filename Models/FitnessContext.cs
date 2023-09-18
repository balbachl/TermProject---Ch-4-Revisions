using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
	public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> options) : base(options)
		{ }
		public DbSet<Members> Membership { get; set; }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Members>().HasData(
				new Members {
					ID = 1, 
					FirstName = "Lisa",
					LastName = "Balbach",
					Email="lbalbach@nmc.edu"
				},
				new Members { 
					ID = 2, 
					FirstName = "Shaggy",
					LastName = "Rogers"
				},
				new Members { 
					ID = 3, 
					FirstName = "Daphne",
					LastName = "Blake" 
				}
			);

		}
	}
}
