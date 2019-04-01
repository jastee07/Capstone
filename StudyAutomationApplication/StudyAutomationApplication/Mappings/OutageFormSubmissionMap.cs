using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class OutageFormSubmissionMap : ClassMap<OutageFormSubmission>
    {
        public OutageFormSubmissionMap()
        {
            Id(x => x.Id, "OutageID");

            Map(x => x.StartDate, "StartDate");
            Map(x => x.EndDate, "EndDate");
            Map(x => x.Reason, "Reason");
            Map(x => x.RequestedBy, "RequestedBy");
            Map(x => x.ClearanceToBeIssuedTo, "ClearanceToBeIssuedTo");
            Map(x => x.SubmitTime, "SubmitTime");
            Map(x => x.BackInService, "BackInService");
            Map(x => x.EmergencyTimeAfter, "EmergencyTimeAfter");
            Map(x => x.LineRequestNumber, "LineRequestNumber");
            Map(x => x.eDartNumber, "eDartNumber");
            Map(x => x.Status, "Status");
            Map(x => x.SwitchingPersonnel, "SwitchingPersonnel");
            Map(x => x.CutIn, "CutIn");
            Map(x => x.OperationsComments);

            Table("OutageFormSubmissions");
        }
    }
}
