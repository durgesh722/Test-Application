using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QBS_CORE_WEBAPI.Data;
using QBS_CORE_WEBAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace QBS_CORE_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly QbsContext _context;

        //public UserProfileController(UserManager<ApplicationUsers> userManager)
        //{
        //    _userManager = userManager;
        //}

        public UserProfileController(QbsContext context)
        {          
            this._context = context;
        }

        [HttpGet]
        [Authorize]
        //GET : /api/UserProfile
        public async Task<Object> GetUserProfile(ApplicationUsers model)
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var userdetails = await _context.ApplicationUsers.SingleOrDefaultAsync(m => m.Id == Convert.ToInt32(userId));           
            return new
            {
                userdetails.FullName,
                userdetails.Email,
                userdetails.LoginId
            };
        }
    }
}