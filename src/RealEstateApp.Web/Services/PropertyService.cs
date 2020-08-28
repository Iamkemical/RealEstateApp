using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using RealEstateApp.Data.DatabaseContexts.ApplicationDbContext;
using RealEstateApp.Data.Entities;
using RealEstateApp.Web.Interfaces;
using RealEstateApp.Web.Models;

namespace RealEstateApp.Web.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly ApplicationDbContext _dbContext;

        public PropertyService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddProperty(PropertyModel model)
        {
            if(model is null) throw new ArgumentNullException(message:"Check whether you have filled the required fields properly", null);
            var property = new Property
            {
                Id = Guid.NewGuid().ToString(),
                Title = model.Title,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                NumberOfBaths = model.NumberOfBaths,
                NumberOfRooms = model.NumberOfRooms,
                NumberOfToilets = model.NumberOfToilets,
                Address = model.Address,
                Price = model.Price,
                ContactPhoneNumber = model.ContactPhoneNumber          
            };
            
            await _dbContext.AddAsync(property);
            await _dbContext.SaveChangesAsync();
        }
    }
}