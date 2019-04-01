using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class GeneratorMap : ClassMap<Generator>
    {
        public GeneratorMap()
        {
            Id(x => x.Id, "GenID");

            Map(x => x.Name, "GenName");
            Map(x => x.PlantName, "PlantName");
            Map(x => x.NodeId, "NodeID");

            Table("Generators");
        }
    }
}
