using System.Threading.Tasks;
using RealEstateApp.Web.Models;

namespace RealEstateApp.Web.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model);
    }
}