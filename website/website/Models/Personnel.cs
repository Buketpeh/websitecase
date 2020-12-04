using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace website.Models
{
    public class Personnel
    {
        [Key]
        public int id { get; set; }
        public string  firstame { get; set; }
        public string  lastname { get; set; }
        public string city { get; set; }
    }
}
