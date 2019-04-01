using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SAA.Models;
using FluentNHibernate.Mapping;

namespace SAA.Mappings
{
    public class PSSEEquipmentMap : ClassMap<PSSEEquipment>
    {
        public PSSEEquipmentMap()
        {
            Id(x => x.PSSEId, "PSSEID");

            Map(x => x.ToBus, "ToBus");
            Map(x => x.FromBus, "FromBus");
            Map(x => x.CktId, "CktID");

            Table("PSSEEquipment");
        }
    }
}
