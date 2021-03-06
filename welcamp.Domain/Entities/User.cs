﻿using System;
using System.Collections.Generic;
using System.Text;

namespace welcamp.Domain.Entities
{
    public class User :BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
