using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class Generator
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string PlantName { get; set; }
        public virtual int NodeId { get; set; }
    }
}
