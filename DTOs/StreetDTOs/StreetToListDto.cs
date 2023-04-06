using CitizenManagementSystemAPI.Entities;

namespace CitizenManagementSystemAPI.DTOs.StreetDTOs
{
    public record StreetToListDto
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; }
    }
}
