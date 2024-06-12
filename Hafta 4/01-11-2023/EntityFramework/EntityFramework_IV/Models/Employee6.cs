using System;
using System.Collections.Generic;

namespace EntityFramework_IV.Models
{
    public partial class Employee6
    {
        public decimal? EmployeeId { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
    }
}
