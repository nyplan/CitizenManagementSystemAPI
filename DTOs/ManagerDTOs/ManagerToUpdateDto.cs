﻿namespace CitizenManagementSystemAPI.DTOs.ManagerDTOs
{
    public record ManagerToUpdateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
    }
}
