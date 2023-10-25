using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PT_Hiberus_API.Domain.IServices;
using PT_Hiberus_API.Domain.Models;
using PT_Hiberus_API.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PT_Hiberus_API.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                user.Password = Encrypt.PasswordEncrypt(user.Password);
                var existence = await _loginService.Login(user);
                if(existence == null)
                {
                    return BadRequest(new { message = "Correo o contraseña incorrectos" });
                }
                return Ok(new { message = "Usuario = XXX" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

