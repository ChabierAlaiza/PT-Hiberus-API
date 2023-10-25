using System;
using PT_Hiberus_API.Domain.Models;

namespace PT_Hiberus_API.Domain.IServices
{
	public interface ILoginService
	{
        Task<User> Login(User user);
    }
}

