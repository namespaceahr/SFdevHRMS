using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Payroll
    {
        public string employeeId { get; set; }
        public int SalaryAmount { get; set; }
        public int bonusAmount { get; set; }
        public string departmentId { get; set; }
    }
}
