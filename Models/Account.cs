using System;
using System.Collections.Generic;

namespace Manage_student.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
}
