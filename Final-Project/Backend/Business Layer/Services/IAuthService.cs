using Data_Layer.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public interface IAuthService
    {
        Task<string> CreateTokenAsync(ApplicationUser user , UserManager<ApplicationUser> userManager);
    }
}
 