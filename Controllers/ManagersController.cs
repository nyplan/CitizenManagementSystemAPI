using AutoMapper;
using CitizenManagementSystemAPI.DAL;
using CitizenManagementSystemAPI.DTOs.ManagerDTOs;
using CitizenManagementSystemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CitizenManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public ManagersController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Get([FromQuery] CheckManagerDto dto)
        {
            Manager? entity = _context.Managers.FirstOrDefault(c => c.Username == dto.Username && c.Password == dto.Password);
            if (entity == null)
            {
                return NotFound("Username or password incorrect");
            }
            return Ok(entity);
        }
        [HttpPost]
        public IActionResult Post([FromQuery] ManagerToAddDto dto)
        {
            Manager entity = _mapper.Map<Manager>(dto);
            _context.Managers.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute]int id, [FromQuery]ManagerToUpdateDto dto)
        {
            Manager entity = _mapper.Map<Manager>(dto);
            entity.ManagerId = id;
            _context.Managers.Update(entity);
            _context.SaveChanges();
            return Ok(entity);
        }

        [HttpPatch("{id}/password")]
        public IActionResult Patch([FromRoute] int id, [FromQuery] string password)
        {
            Manager? entity = _context.Managers.FirstOrDefault(c => c.ManagerId == id);
            entity.Password = password;
            _context.SaveChanges();
            return Ok(entity);
        }
    }
}
