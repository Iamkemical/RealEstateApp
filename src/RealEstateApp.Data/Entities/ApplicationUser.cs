using Microsoft.AspNetCore.Identity;

namespace RealEstateApp.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName {get; set; }
    }
}