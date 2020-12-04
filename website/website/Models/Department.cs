using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace website.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string DepartmentName { get; set; }
    }
}
