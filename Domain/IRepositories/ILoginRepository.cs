using System;
using PT_Hiberus_API.Domain.Models;

namespace PT_Hiberus_API.Domain.IRepositories
{
	public interface ILoginRepository
	{
		Task<User> Login(User user);
	}
}

