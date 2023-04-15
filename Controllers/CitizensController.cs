using AutoMapper;
using CitizenManagementSystemAPI.DAL;
using CitizenManagementSystemAPI.DTOs.CitizenDTOs;
using CitizenManagementSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace CitizenManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizensController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMemoryCache _memoryCache;
        private readonly IMapper _mapper;
        public CitizensController(ApiContext context, IMapper mapper, IMemoryCache cache)
        {
            _context = context;
            _mapper = mapper;
            _memoryCache = cache;
        }
        [HttpGet]
        public IActionResult GetCitizens()
        {
            const string cacheKey = "CitizensList";

            if (_memoryCache.TryGetValue(cacheKey, out IEnumerable<CitizensToListDto> dtos))
            {
                return Ok(dtos);
            }
            else
            {
                IQueryable<Citizen> entities = _context.Citizens
                                                .Include(c => c.Gender)
                                                .Include(c => c.BirthPlace)
                                                .Include(c => c.CurrentPlace.Region)
                                                .Include(c => c.CurrentPlace.Street)
                                                .Include(c => c.CurrentPlace.Entrance)
                                                .Include(c => c.Father)
                                                .Include(c => c.Mother);
                dtos = _mapper.Map<List<CitizensToListDto>>(entities);

                var cacheOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(5));
                _memoryCache.Set(cacheKey, dtos, cacheOptions);
                return Ok(dtos);
            }
            
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
