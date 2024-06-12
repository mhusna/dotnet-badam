using System;
using System.Collections.Generic;

namespace EntityFramework_IV.Models
{
    public partial class Employee3
    {
        public decimal? EmployeeId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public decimal? Salary { get; set; }
        public DateTime Hiredate { get; set; }
    }
}
