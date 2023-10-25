using System;
using PT_Hiberus_API.Domain.Models;

namespace PT_Hiberus_API.Domain.IServices
{
	public interface IUserService
	{
        Task Register(User user);
        Task<bool> ValidateExistence(User user);
    }
}

