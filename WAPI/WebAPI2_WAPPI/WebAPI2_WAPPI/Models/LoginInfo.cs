using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI2_WAPPI.Models
{
    public class LoginInfo
    {

        public int UserID { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }
        public int FullName { get; set; }
        public int Email { get; set; }
        public int Contact { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }

    }
}