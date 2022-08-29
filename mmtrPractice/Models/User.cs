using System;
using System.Collections.Generic;
using System.Text;

namespace mmtrPractice.Models
{
    public class User
    {
        public User()
        {
            Orders = new List<Order>();
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
