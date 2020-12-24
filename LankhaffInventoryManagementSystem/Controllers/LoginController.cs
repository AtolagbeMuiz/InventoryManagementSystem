using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace LankhaffInventoryManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticationSchemeProvider authenticationSchemeProvider;
        public LoginController(IAuthenticationSchemeProvider authenticationSchemeProvider)
        {
            this.authenticationSchemeProvider = authenticationSchemeProvider;
        }
        public async Task<IActionResult> Login()
        {
            var allSchemeProvider = (await authenticationSchemeProvider.GetAllSchemesAsync())
                .Select(n => n.DisplayName)
                .Where(n => !String.IsNullOrEmpty(n));

            return View(allSchemeProvider);
        }
        
        public IActionResult SignIn(string provider)
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" }, provider);
        }
    }
}