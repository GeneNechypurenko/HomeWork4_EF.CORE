﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class UserSettings
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string Language { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
