namespace CitizenManagementSystemAPI.Entities
{
    public class Street
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public ICollection<Entrance> Entrances { get; set; }
    }
}
