using System;
using Microsoft.AspNetCore.Mvc;
using Prestige.Commmon.Constants;

namespace Prestige.WebApi.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected bool IsAdmin
            => this.User.IsInRole(CommonConstants.AdminRole);

        protected Guid UserId
            => string.IsNullOrWhiteSpace(User?.Identity?.Name) ? 
                Guid.Empty : 
                Guid.Parse(User.Identity.Name);
    }
}