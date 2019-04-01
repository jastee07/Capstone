using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class OutageLineMap : ClassMap<OutageLine>
    {
        public OutageLineMap()
        {
            Id(x => x.Id, "OutageID");

            Map(x => x.FRBanchId, "FRBranchID");
            Map(x => x.InService, "InService");

            Table("OutageLines");
        }
    }
}
