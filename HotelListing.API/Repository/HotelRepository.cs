using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelRepository(HotelListingDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Hotel> GetHotelDetails(int? id)
        {
            if (id == null) return null;
            return await _context.Hotels
                .Include(country => country.Country)
                .FirstOrDefaultAsync(item => item.Id.Equals(id));
        }
    }
}
