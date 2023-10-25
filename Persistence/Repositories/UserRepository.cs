using System;
using Microsoft.EntityFrameworkCore;
using PT_Hiberus_API.Domain.IRepositories;
using PT_Hiberus_API.Domain.Models;
using PT_Hiberus_API.Persistence.Context;

namespace PT_Hiberus_API.Persistence.Repositories
{
	public class UserRepository: IUserRepository
	{
		private readonly AplicationDbContext _context;

		public UserRepository(AplicationDbContext context)
		{
			_context = context;
		}

		public async Task Register(User user)
		{
			_context.Add(user);
			await _context.SaveChangesAsync();
		}

		public async Task<bool> ValidateExistence(User user)
		{
			var validateExistence = await _context.Users.AnyAsync(m => m.Email == user.Email);

			return validateExistence;
		}
	}
}

