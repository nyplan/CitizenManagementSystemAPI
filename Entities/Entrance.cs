namespace CitizenManagementSystemAPI.Entities
{
    public class Entrance
    {
        public int EntranceId { get; set; }
        public string EntranceName { get; set; }
        public int StreetId { get; set; }
        public Street Street { get; set; }
    }
}
