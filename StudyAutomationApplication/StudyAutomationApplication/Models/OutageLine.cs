using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class OutageLine
    {
        public virtual int Id { get; set; }
        public virtual int FRBanchId { get; set; }
        public bool InService { get; set; }
    }
}
