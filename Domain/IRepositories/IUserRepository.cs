using System;
using PT_Hiberus_API.Domain.Models;

namespace PT_Hiberus_API.Domain.IRepositories
{
	public interface IUserRepository
	{
		Task Register(User user);

		Task<bool> ValidateExistence(User user);
	}
}

