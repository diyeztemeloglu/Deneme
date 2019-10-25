using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTranscript
{
    public class Department
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int CreditCount { get; set; }
        private string HeadOfDepartment { get; set; }
    }
}
