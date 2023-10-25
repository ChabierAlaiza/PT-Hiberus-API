using System;
using PT_Hiberus_API.Domain.IRepositories;
using PT_Hiberus_API.Domain.IServices;
using PT_Hiberus_API.Domain.Models;

namespace PT_Hiberus_API.Services
{
	public class UserService: IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public async Task Register(User user) {
			await _userRepository.Register(user);
		}

		public async Task<bool> ValidateExistence(User user)
		{
			return await _userRepository.ValidateExistence(user);
		}

	}
}

