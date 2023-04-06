using CitizenManagementSystemAPI.Entities;

namespace CitizenManagementSystemAPI.DTOs.GenderDTOs
{
    public record GenderToListDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
