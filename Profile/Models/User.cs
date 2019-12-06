using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Profile.Models
{
    public class User
    {
        int id { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string DateOfBirth { get; set; }
        string Email { get; set; }
    }
}