using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using WebApplication3.Dtos;
using WebApplication3.Models;

namespace WebApplication3.Controllers.Api
{
    [AllowAnonymous]
    public class CitiesController : ApiController
    {
        private ApplicationDbContext _context;

        public CitiesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET:  /api/cities   // retunrs list of all the cities
        public IEnumerable<CityDto> GetCities(string query = null)
        {
            IQueryable<City> cityQuery = _context.Cities;

            if (!string.IsNullOrWhiteSpace(query))
            {
                cityQuery = cityQuery.Where(c => c.CityName.Contains(query));
            }

            var cityDtos = cityQuery.ToList().Select(Mapper.Map<City, CityDto>);


            // Now suppose you wanted to reutrn some other related class data here I mean if the City class has some other class
            // in it then you will have to create anotyher DTO for that class and then add it in the cityDTO and then Use INclude LINQ Query toi
            // include it and then send the result back to UI and then render it accordingly. BUT DO  NOT USE DOMAIN CLASSES
            // in API EVER!!!!!
            return cityDtos;
        }

        //api/cities/1
        [Authorize(Roles = "CanManageMovies")]
        public IHttpActionResult GetCity(int id)
        {
            var city = _context.Cities.SingleOrDefault(c => c.Id == id);
            if (city == null)
                return NotFound();

            return Ok(Mapper.Map<City, CityDto>(city));
        }

        // POST: api/cities
        [HttpPost]
        public IHttpActionResult CreateCity(CityDto cityDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var city = Mapper.Map<CityDto, City>(cityDto);
            _context.Cities.Add(city);
            _context.SaveChanges();

            cityDto.Id = city.Id;
            return Created(new Uri(Request.RequestUri + "/" + cityDto.Id), cityDto);
        }

        // Put /api/cities/1
        [HttpPut]
        public void UpdateCity(int id, CityDto cityDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var cityInDb = _context.Cities.SingleOrDefault(c => c.Id == id);

            if (cityInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(cityDto, cityInDb);

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


// in poackage manger constolw type install-package bootbox -version:4.3.0



// Custom Error:

/*

 Of we keep it off then .net will simply throw the exception and we might see some inside detail of our application, just like yellow page of death
 if we keep custom error on then we can see a custom page and there we can display the exception if we want, if not then a generic error page]
 if we keep custom error to remote then for live sutomer they will see the custoim page hpwever the loclaqhost will see the exceptopm/yellow page of death.
 ideally we should keep it as "RemoteOnly"*/


// 3 errors:
// 1.  standard action level excetion - handled by handle  filters.Add(new HandleErrorAttribute()); in filter.config file
// 2. Invvalid route exception is handled by   
// 3. IIS Exception or some static resource www.abc/globe.jpeg does not even make to asp code
// now we are trying to handle error w/ exception which does not even make it to the application, 
