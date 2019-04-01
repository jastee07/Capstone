using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class OutageGenerator
    {
        public virtual int Id { get; set; }
        public virtual int GenId { get; set; }
        public virtual bool InService { get; set; }
    }
}
