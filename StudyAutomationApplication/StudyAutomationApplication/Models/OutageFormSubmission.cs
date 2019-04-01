using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class OutageFormSubmission
    {
        public virtual int Id { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime EndDate { get; set; }
        public virtual string Reason { get; set; }
        public virtual string RequestedBy { get; set; }
        public virtual string ClearanceToBeIssuedTo { get; set; }
        public virtual DateTime SubmitTime { get; set; }
        public virtual bool BackInService { get; set; }
        public virtual DateTime EmergencyTimeAfter { get; set; }
        public virtual int LineRequestNumber { get; set; }
        public virtual int eDartNumber { get; set; }
        public virtual string Status { get; set; }
        public virtual string SwitchingPersonnel { get; set; }
        public virtual string CutIn { get; set; }
        public virtual string OperationsComments { get; set; }
    }
}
