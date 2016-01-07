using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Training
    {
        public int trainingId { get; set; }
        public string employeeId { get; set; }
        public string topic { get; set;}
        public string reviewTraining { get; set; }
    }
}
