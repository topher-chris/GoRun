using System;
using System.Collections.Generic;

namespace GoRun.Models
{
    public partial class Users
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Secretword { get; set; }
    }
}
