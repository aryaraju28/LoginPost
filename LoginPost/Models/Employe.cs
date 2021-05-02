using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPost.Models
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}