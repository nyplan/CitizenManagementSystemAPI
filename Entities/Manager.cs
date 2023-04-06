namespace CitizenManagementSystemAPI.Entities
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
    }
}
