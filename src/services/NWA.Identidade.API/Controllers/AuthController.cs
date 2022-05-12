using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NWA.Identidade.API.Models;
using System.Threading.Tasks;

namespace NWA.Identidade.API.Controllers
{
    public class AuthController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthController(SignInManager<IdentityUser> signManager, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signManager;
        }
       

        public async Task<ActionResult> Registrar(UsuarioRegistro usuarioRegistro)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var user = new IdentityUser
            {
                UserName = usuarioRegistro.Email,
                Email = usuarioRegistro.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, usuarioRegistro.Senha);

            if(result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok();
            }

            return BadRequest(result);
        }

        public async Task<ActionResult> Login(UsuarioLogin usuarioLogin)
        {
            if (!ModelState.IsValid) return BadRequest();

            var result = _signInManager.PasswordSignInAsync(usuarioLogin.Email, usuarioLogin.Senha,
                false, true);

            if(result.IsCompletedSuccessfully)
            {
                return Ok();
            }

            return BadRequest();
             
        }
    }
}
