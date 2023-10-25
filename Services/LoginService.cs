using System;
using PT_Hiberus_API.Domain.IRepositories;
using PT_Hiberus_API.Domain.IServices;
using PT_Hiberus_API.Domain.Models;

namespace PT_Hiberus_API.Services
{
	public class LoginService: ILoginService
	{ 
		private readonly ILoginRepository _loginRepository;

		public LoginService(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}

		public async Task<User> Login(User user) {
			return await _loginRepository.Login(user);
		}
	}
}

