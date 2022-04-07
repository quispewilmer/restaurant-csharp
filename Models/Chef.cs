using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace restaurant_csharp.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Genre { get; set; }
        public decimal Earn { get; set; }

    }
}
