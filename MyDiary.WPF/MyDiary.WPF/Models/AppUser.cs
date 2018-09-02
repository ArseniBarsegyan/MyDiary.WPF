﻿using System.Collections.Generic;

namespace MyDiary.WPF.Models
{
    public class AppUser
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public IEnumerable<Note> Notes { get; set; }
    }
}