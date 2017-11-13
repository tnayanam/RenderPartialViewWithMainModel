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
        public IEnumerable<CityDto> GetCities()
        {
            var cityDtos = _context.Cities.ToList().Select(Mapper.Map<City, CityDto>);


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