using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class BranchMap : ClassMap<Branch>
    {
        public BranchMap()
        {
            Id(x => x.Id, "BranchId");

            Map(x => x.BranchName, "BranchName");
            Map(x => x.BranchTag, "BranchTag");
            Map(x => x.BranchType, "BranchType");
            Map(x => x.FromNodeId, "FromNodeID");
            Map(x => x.ToNodeId, "ToNodeID");
            Map(x => x.CircuitId, "CircuitID");
            Map(x => x.OperStatus, "OperStatus");
            Map(x => x.ImpStatus, "ImpStatus");
            Map(x => x.HasFromTerminal, "HasFromTerminal");
            Map(x => x.Category, "Category");
            Map(x => x.Configuration, "Configuration");
            Map(x => x.Interconnection, "Interconnection");
            Map(x => x.RevDate, "RevDate");

            Table("Branches");
        }
    }
}
