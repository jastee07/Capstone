using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class FRPSSEMapping
    {
        public virtual int Id { get; set; }
        public virtual int FacilityRatingsBranchId { get; set; }
        public virtual int PSSEId { get; set; }
        public virtual string OpenNet { get; set; }
    }
}
