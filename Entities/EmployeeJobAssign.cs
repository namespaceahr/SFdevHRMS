using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class EmployeeJobAssign
    {
        public string employeeId { get; set; }
        public string jobId { get; set; }
        public string jobDescription { get; set; }
        public string jobAssignByAdmin { get; set; }
        public DateTime jobStartDate { get; set; }
        public DateTime jobDeadlineDate { get; set; }
        public string departmentId { get; set; }
        public string jobStatus { get; set; }
    }
}
