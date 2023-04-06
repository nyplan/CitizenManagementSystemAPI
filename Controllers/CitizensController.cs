using AutoMapper;
using CitizenManagementSystemAPI.DAL;
using CitizenManagementSystemAPI.DTOs.CitizenDTOs;
using CitizenManagementSystemAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CitizenManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizensController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public CitizensController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetCitizens()
        {
            IQueryable<Citizen> entities = _context.Citizens
                                                .Include(c => c.Gender)
                                                .Include(c => c.BirthPlace)
                                                .Include(c => c.CurrentPlace.Region)
                                                .Include(c => c.CurrentPlace.Street)
                                                .Include(c => c.CurrentPlace.Entrance)
                                                .Include(c => c.Father)
                                                .Include(c => c.Mother);
            IEnumerable<CitizensToListDto> dtos = _mapper.Map<List<CitizensToListDto>>(entities);
            return Ok(dtos);
        }
        [HttpGet("{pin}")]
        public IActionResult GetParent(string pin)
        {
            Citizen entity = _context.Citizens.Where(c => c.Pin == pin)
                                               .Include(c => c.Gender)
                                               .Include(c => c.BirthPlace)
                                               .Include(c => c.CurrentPlace.Region)
                                               .Include(c => c.CurrentPlace.Street)
                                               .Include(c => c.CurrentPlace.Entrance)
                                               .Include(c => c.Father)
                                               .Include(c => c.Mother).First();
            CitizenByPinDto dto = _mapper.Map<CitizenByPinDto>(entity);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Post([FromQuery] CitizenToAddDto data)
        {
            Citizen citizen = _mapper.Map<Citizen>(data);
            citizen.MotherId = _context.Citizens.FirstOrDefault(c => c.Pin == data.MotherPin)?.CitizenId;
            citizen.FatherId = _context.Citizens.FirstOrDefault(c => c.Pin == data.FatherPin)?.CitizenId;

            var existingCurrentPlace = _context.CurrentPlaces.FirstOrDefault(c =>
                                 c.RegionId == data.CurrentPlace.RegionId
                                 && c.StreetId == data.CurrentPlace.StreetId
                                 && c.EntranceId == data.CurrentPlace.EntranceId);
            if (existingCurrentPlace is not null)
            {
                citizen.CurrentPlaceId = existingCurrentPlace.CurrentPlaceId;
                citizen.CurrentPlace = null;
            }
            _context.Citizens.Add(citizen);
            _context.SaveChanges();
            return Ok(citizen);
        }
    }
}
