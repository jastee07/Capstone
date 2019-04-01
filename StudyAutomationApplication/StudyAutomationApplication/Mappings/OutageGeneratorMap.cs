using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class OutageGeneratorMap : ClassMap<OutageGenerator>
    {
        public OutageGeneratorMap()
        {
            CompositeId()
                .KeyReference(x => x.Id, "OutageID")
                .KeyReference(x => x.GenId, "GenID");

            Map(x => x.InService, "InService");

            Table("OutageGenerators");
        }
    }
}
