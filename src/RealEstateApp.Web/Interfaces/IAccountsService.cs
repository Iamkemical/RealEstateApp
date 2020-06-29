using System.Threading.Tasks;
using RealEstateApp.Data.Entities;
using RealEstateApp.Web.Models;

namespace RealEstateApp.Web.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}