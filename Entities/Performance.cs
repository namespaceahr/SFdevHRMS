using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Performance
    {
        public string employeeId { get; set; }
        public string PerformanceId { get; set; }
        public string reviewComment { get; set; }
        public DateTime reviewDate { get; set; }
        public string reviewByAdmin { get; set; }
        
    }
}
