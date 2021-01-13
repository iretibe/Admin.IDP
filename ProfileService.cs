using Admin.IDP.Entity;
using Admin.IDP.Models;
using Admin.IDP.Services;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Admin.IDP
{
    public class ProfileService : IProfileService
    {
        private readonly ICompanyService _repo;
        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _claimsFactory;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileService(UserManager<ApplicationUser> userManager, 
            IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory, PersoltaxadmindbContext context,
            ICompanyService repo)
        {
            _userManager = userManager;
            _claimsFactory = claimsFactory;
            _repo = repo;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            var principal = await _claimsFactory.CreateAsync(user);

            var claims = principal.Claims.ToList();
            claims = claims.Where(claim => context.RequestedClaimTypes.Contains(claim.Type)).ToList();

            // Add custom claims in token here based on user properties or any other source
            claims.Add(new Claim("WebSite", user.AssemblyId.ToString() ?? string.Empty));
            claims.Add(new Claim("AssemblyCode", user.AssemblyCode.ToString() ?? string.Empty));

            var obj1 = await _repo.GetAssemblyCredentials(user.AssemblyCode);
            var obj2 = await _repo.GetUserRecordsAsync(user.AssemblyCode, user.Id);

            claims.Add(new Claim("AssemblyName", obj1.FirstOrDefault().szAssemblyName.ToString() ?? string.Empty));
            claims.Add(new Claim("AssemblyLogo", obj1.FirstOrDefault().szLogo.ToString() ?? string.Empty));
            claims.Add(new Claim("uniAssemblyId", obj2.FirstOrDefault().uniAssemblyId.ToString() ?? string.Empty));
            claims.Add(new Claim("FirstName", obj2.FirstOrDefault().FirstName.ToString() ?? string.Empty));
            claims.Add(new Claim("LastName", obj2.FirstOrDefault().LastName.ToString() ?? string.Empty));
            claims.Add(new Claim("CashLimit", obj2.FirstOrDefault().nCashLimit.ToString() ?? string.Empty));
            claims.Add(new Claim("AgentId", obj2.FirstOrDefault().AgentId.ToString() ?? string.Empty));
            claims.Add(new Claim("iGroupId", obj2.FirstOrDefault().iGroupId.ToString() ?? string.Empty));
            claims.Add(new Claim("szGroupName", obj2.FirstOrDefault().szGroupName.ToString() ?? string.Empty));
            claims.Add(new Claim("pkId", obj2.FirstOrDefault().pkId.ToString() ?? string.Empty));
            claims.Add(new Claim("iSegmentId", obj2.FirstOrDefault().iSegmentId.ToString() ?? string.Empty));

            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            context.IsActive = user != null;
        }
    }
}
