﻿using System.Collections.Generic;

namespace WebSite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Ad> Enrollments { get; set; }
    }
}
