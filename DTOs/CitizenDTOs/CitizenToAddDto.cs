using CitizenManagementSystemAPI.DTOs.CurrentPlaceDto;
using CitizenManagementSystemAPI.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CitizenManagementSystemAPI.DTOs.CitizenDTOs
{
    public record CitizenToAddDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int BirthPlaceId { get; set; }
        public CurrentPlaceAddDto CurrentPlace { get; set; }
        public int GenderId { get; set; }
        public string? FatherPin { get; set; }
        public string? MotherPin { get; set; }
    }
}
