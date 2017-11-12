using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers.Api
{
    public class CitiesController : ApiController
    {
        private ApplicationDbContext _context;

        public CitiesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET:  /api/cities   // retunrs list of all the cities
        public IEnumerable<City> GetCities()
        {
            return _context.Cities.ToList();
        }

        //api/cities/1
        public City GetCity(int id)
        {
            var city = _context.Cities.SingleOrDefault(c => c.Id == id);
            if (city == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return city;
        }

        // POST: api/cities
        [HttpPost]
        public City CreateCity(City city)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Cities.Add(city);
            _context.SaveChanges();

            return city;
        }

        // Put /api/cities/1
        [HttpPut]
        public void UpdateCity(int id, City city)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var cityInDb = _context.Cities.SingleOrDefault(c => c.Id == id);

            if (cityInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            cityInDb.CityName = city.CityName;
            cityInDb.Country = city.Country;

            _context.SaveChanges();
        }

        // DELETE /api/cities/1

        [HttpDelete]
        public void DeleteCity(int id)
        {
            var cityInDb = _context.Cities.SingleOrDefault(c => c.Id == id);

            if (cityInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Cities.Remove(cityInDb);
            _context.SaveChanges();
        }
    }
}

// Web Api are data end points which can be consumed by tablets, mobiles or webapp. we can also expose end points for data-edit
// Get - to get a resporce.
// POST:to create a new resource.
// Put: to modify an existing resource.
// delete : to delete