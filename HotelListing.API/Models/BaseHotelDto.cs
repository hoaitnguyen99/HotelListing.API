using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models
{
    public class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
