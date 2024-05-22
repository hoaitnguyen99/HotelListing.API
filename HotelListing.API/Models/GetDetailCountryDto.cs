using HotelListing.API.Models.Hotels;

namespace HotelListing.API.Models
{
    public class GetDetailCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
