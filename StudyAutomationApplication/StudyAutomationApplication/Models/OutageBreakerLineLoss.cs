using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class OutageBreakerLineLoss
    {
        public virtual int BreakerId { get; set; }
        public virtual int OutageBranchId { get; set; }
    }
}
