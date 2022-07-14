using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using QBS_CORE_WEBAPI.Data;
using QBS_CORE_WEBAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace QBS_CORE_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly QbsContext _context;
        private readonly ApplicationSettings _appSettings;

        public AccountController(QbsContext context, IOptions<ApplicationSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

        // GET: api/Account
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_user_m>>> Gettbl_user_m()
        {
            return await _context.tbl_user_m.ToListAsync();
        }

        [HttpPost]
        [Route("Register")]
        //POST : /api/Account/Register
        public async Task<Object> PostApplicationUser(tbl_user_m model)
        {
            var applicationUser = new tbl_user_m()
            {
                LoginId = model.LoginId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                DateOfBirth = model.DateOfBirth,
                Mobile = model.Mobile,
                Gender = model.Gender,
                Address = model.Address,
                PinCode = model.PinCode,
                Password = model.Password                
            };

            try
            {
                // var result = await _userManager.CreateAsync(applicationUser, model.Password);
                _context.Add(applicationUser);
                var result = await _context.SaveChangesAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                if(ex.InnerException.ToString().Contains("duplicate"))
                {
                    return "Duplicate Record Found";
                }


                return 0;
            }
        }

        [HttpPost]
        [Route("Login")]
        //POST : /api/ApplicationUser/Login
        public async Task<IActionResult> Login(LoginModel model)
        {
            var userdetails = await _context.tbl_user_m
            .SingleOrDefaultAsync(m => m.LoginId == model.LoginId && m.Password == model.Password);
            if (userdetails != null)
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                 {
                        new Claim("UserID",userdetails.Id.ToString())
                 }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
            //HttpContext.Session.SetString("userId", ApplicationUsers.Name);

        }
       
    }
}
