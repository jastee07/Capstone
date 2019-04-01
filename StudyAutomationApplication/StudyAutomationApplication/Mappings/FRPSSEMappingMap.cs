using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class FRPSSEMappingMap : ClassMap<FRPSSEMapping>
    {
        public FRPSSEMappingMap()
        {
            Id(x => x.Id, "MapID");

            Map(x => x.FacilityRatingsBranchId, "FacilityRatingsBranchID");
            Map(x => x.PSSEId, "PSSEID");
            Map(x => x.OpenNet, "OpenNet");

            Table("FRPSSEMapping");
        }
    }
}
