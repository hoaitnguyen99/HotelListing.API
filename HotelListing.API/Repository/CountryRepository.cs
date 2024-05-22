using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly HotelListingDbContext _context;

        public CountryRepository(HotelListingDbContext context) : base(context)
        {
            this._context = context;
        }
        public async Task<Country> GetCountryWithHotels(int? id) { 
            if (id == null) return null;
            return await _context.Countries
                .Include(hotel => hotel.Hotels)
                .FirstOrDefaultAsync(item => item.Id.Equals(id));
        }
    }
}
