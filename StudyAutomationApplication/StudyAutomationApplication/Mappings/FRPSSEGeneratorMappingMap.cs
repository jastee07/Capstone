using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class FRPSSEGeneratorMappingMap : ClassMap<FRPSSEGeneratorMapping>
    {
        public FRPSSEGeneratorMappingMap()
        {
            CompositeId()
                .KeyReference(x => x.GenId, "GenID")
                .KeyReference(x => x.PSSEId, "PSSEID");

            Table("FRPSSEGeneratorMapping");
        }
    }
}
