using CitizenManagementSystemAPI.Entities;

namespace CitizenManagementSystemAPI.DTOs.EntranceDTOs
{
    public record EntranceToListDto
    {
        public int EntranceId { get; set; }
        public string EntranceName { get; set; }
    }
}
