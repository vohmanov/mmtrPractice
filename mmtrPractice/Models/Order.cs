using System;
using System.Collections.Generic;
using System.Text;

namespace mmtrPractice.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string WorkType { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string PeriodExecution { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
