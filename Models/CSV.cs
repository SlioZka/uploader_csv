using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testBits.Models
{
    public class CSV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DateDay { get; set; }
        public int DateMonth { get; set; }
        public int DateYear { get; set; }
        public bool Married { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
