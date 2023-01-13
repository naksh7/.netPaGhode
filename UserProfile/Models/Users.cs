using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserProfile.Models
{
    public class Users
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string contact { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string userName { get; set; }
    }
}