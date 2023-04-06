namespace CitizenManagementSystemAPI.DTOs.ManagerDTOs
{
    public record ManagerToAddDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
