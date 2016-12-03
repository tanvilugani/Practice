using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public bool IsSelected { get; set; }
    }
}