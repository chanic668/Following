using FollowingServerDAL.Context;
using FollowingServerDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace FollowingServerDAL.Repository
{
    public class CountryRepository 
    {
        private readonly FollowingDBContext _context;

        public CountryRepository(FollowingDBContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetAllCountryAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<List<City>> GetAllCityAsync()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> AddCityAsync(City city)
        {
            await _context.Cities.AddAsync(city);
            await _context.SaveChangesAsync();
            return city;
        }

        public async Task<Country> AddCountryAsync(Country country)
        {
            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
            return country;
        }
    }
}
