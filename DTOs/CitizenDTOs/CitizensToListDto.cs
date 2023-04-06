using CitizenManagementSystemAPI.Entities;

namespace CitizenManagementSystemAPI.DTOs.CitizenDTOs
{
    public record CitizensToListDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string CurrentPlace { get; set; }
        public string Gender { get; set; }
        public string? FatherPin { get; set; }
        public string? MotherPin { get; set; }
    }
}
