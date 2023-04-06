using CitizenManagementSystemAPI.Entities;

namespace CitizenManagementSystemAPI.DTOs.RegionDTOs
{
    public record RegionToListDto
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
    }
}
