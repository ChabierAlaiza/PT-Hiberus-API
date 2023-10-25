using System;
using Microsoft.EntityFrameworkCore;
using PT_Hiberus_API.Domain.IRepositories;
using PT_Hiberus_API.Domain.Models;
using PT_Hiberus_API.Persistence.Context;

namespace PT_Hiberus_API.Persistence.Repositories
{
	public class LoginRepository: ILoginRepository
	{
		private readonly AplicationDbContext _context;

		public LoginRepository(AplicationDbContext context)
		{
			_context = context;
		}

		public async Task<User> Login(User user)
		{
			var existence = await _context.Users
				.Where(m => m.Email == user.Email && m.Password == user.Password).FirstOrDefaultAsync();

			return existence;
		}
	}
}

