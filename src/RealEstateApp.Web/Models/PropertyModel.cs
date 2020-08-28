using System.ComponentModel.DataAnnotations;

namespace RealEstateApp.Web.Models
{
    public class PropertyModel
    {
        [Required (ErrorMessage = "Enter the name of the property!")]
        public string Title { get; set; } // 3 Bedroom flat in Abule Egba.

        public string ImageUrl { get; set; }

        [Required (ErrorMessage = "Enter the price of the property!")]
        public double Price { get; set; }

        [Required (ErrorMessage = "Enter the description of the property!")]
        public string Description { get; set; }

        [Required (ErrorMessage = "Enter the number of rooms in the property!")]
        public int NumberOfRooms { get; set; }

        [Required (ErrorMessage = "Enter the number of baths in the property!")]
        public int NumberOfBaths { get; set; }

        [Required (ErrorMessage = "Enter the number of toilets in the property!")]
        public int NumberOfToilets  { get; set; }

        [Required (ErrorMessage = "Enter the address of the property!")]
        public string Address { get; set; }
        
        [Required (ErrorMessage = "Enter your contact phone number!")]
        public string ContactPhoneNumber { get; set; }
    }
}