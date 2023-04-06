using AutoMapper;
using CitizenManagementSystemAPI.DAL;
using CitizenManagementSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CitizenManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ToolsController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet("genders")]
        public IActionResult GetGenders()
        {
            IQueryable<EnumValue> entities =  _context.EnumValues.Where(c => c.KeyId == 1);
            return Ok(entities);
        }
        [HttpGet("regions")]
        public IActionResult GetRegions()
        {
            IQueryable<Region> entities = _context.Regions;
            return Ok(entities);
        }
        [HttpGet("region/{id}/streets")]
        public IActionResult GetStreets([FromRoute]int id)
        {
            IQueryable<Street> entities = _context.Streets.Where(c => c.RegionId == id);
            return Ok(entities);
        }
        [HttpGet("street/{id}/entrances")]
        public IActionResult GetEntrances([FromRoute] int id)
        {
            IQueryable<Entrance> entities = _context.Entrances.Where(c => c.StreetId == id);
            return Ok(entities);
        }
    }
}
