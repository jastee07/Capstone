using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class PSSEEquipment
    {
        public virtual int PSSEId { get; set; }
        public virtual string FromBus { get; set; }
        public virtual string ToBus { get; set; }
        public virtual int CktId { get; set; }
    }
}
