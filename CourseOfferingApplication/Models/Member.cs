﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseOfferingApplication.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
