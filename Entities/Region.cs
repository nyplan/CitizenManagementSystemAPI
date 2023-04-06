namespace CitizenManagementSystemAPI.Entities
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public ICollection<Street> Streets { get; set; }
    }
}
