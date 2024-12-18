﻿using System.Text.Json.Serialization;

namespace UrphaCapital.Domain.Entities.Auth
{
    public class Student
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }

        [JsonIgnore]
        public List<int> CourseIds { get; set; } = new List<int>();
        public string Role { get; set; }
    }
}
