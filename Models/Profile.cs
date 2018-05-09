using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Profile()
        {
            FirstName = "Vince";
            LastName = "DeGiorgio";
            Email = "vincent.degiorgio@aero.bombardier.com";
        }
    }
}