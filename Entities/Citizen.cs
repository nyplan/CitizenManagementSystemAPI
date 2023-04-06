using Microsoft.VisualBasic;

namespace CitizenManagementSystemAPI.Entities
{
    public class Citizen
    {
        public int CitizenId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pin { get; set; }
        public DateTime BirthDate { get; set; }
        public int BirthPlaceId { get; set; }
        public Region BirthPlace { get; set; }
        public int CurrentPlaceId { get; set; }
        public CurrentPlace? CurrentPlace { get; set; }
        public int GenderId { get; set; }
        public EnumValue Gender { get; set; }
        public int? FatherId { get; set; }
        public Citizen? Father { get; set; }
        public int? MotherId { get; set; }
        public Citizen? Mother { get; set; }
        public bool IsDeleted { get; set; }
    }
}
