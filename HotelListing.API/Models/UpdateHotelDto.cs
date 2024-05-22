using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models
{
    public class UpdateHotelDto : BaseHotelDto
    {

        public int Id { get; set; }
        public double Rating { get; set; }
        public int CountryId { get; set; }
    }
}
