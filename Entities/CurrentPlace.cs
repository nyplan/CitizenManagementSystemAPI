namespace CitizenManagementSystemAPI.Entities
{
    public class CurrentPlace
    {
        public int CurrentPlaceId { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public int StreetId { get; set; }
        public Street Street { get; set; }
        public int EntranceId { get; set; }
        public Entrance Entrance { get; set; }
    }
}
