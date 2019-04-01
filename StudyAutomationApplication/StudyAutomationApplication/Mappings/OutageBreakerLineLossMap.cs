using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class OutageBreakerLineLossMap : ClassMap<OutageBreakerLineLoss>
    {
        public OutageBreakerLineLossMap()
        {
            CompositeId()
                .KeyReference(x => x.BreakerId, "BreakerID")
                .KeyReference(x => x.OutageBranchId, "OutageBranchID");

            Table("OutageBreakerLineLoss");
        }
    }
}
