using HotelListing.API.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models
{
    public class HotelDetailsDto : BaseHotelDto
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public GetCountryDto Country { get; set; }
    }
}
