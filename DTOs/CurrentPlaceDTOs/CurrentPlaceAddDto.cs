using CitizenManagementSystemAPI.Entities;

namespace CitizenManagementSystemAPI.DTOs.CurrentPlaceDto
{
    public record CurrentPlaceAddDto
    {
        public int RegionId { get; set; }
        public int StreetId { get; set; }
        public int EntranceId { get; set; }
    }
}
