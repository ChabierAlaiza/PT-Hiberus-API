using System;
using Microsoft.EntityFrameworkCore;
using PT_Hiberus_API.Domain.Models;

namespace PT_Hiberus_API.Persistence.Context
{
	public class AplicationDbContext: DbContext
	{
		public AplicationDbContext(DbContextOptions<AplicationDbContext> options) :base(options)
		{

		}

        public DbSet<User> Users { get; set; }
    }
}

