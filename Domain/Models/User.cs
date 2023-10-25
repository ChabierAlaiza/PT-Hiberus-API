using System;
using System.ComponentModel.DataAnnotations;

namespace PT_Hiberus_API.Domain.Models
{
	public class User
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

        [MaxLength(250)]
        public string Surname { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}

