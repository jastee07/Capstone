using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA.Models
{
    public class Branch
    {
        public virtual int Id { get; set; }
        public virtual string BranchName { get; set; }
        public virtual string BranchTag { get; set; }
        public virtual string BranchType { get; set; }
        public virtual int FromNodeId { get; set; }
        public virtual int ToNodeId { get; set; }
        public virtual int CircuitId { get; set; }
        public virtual string OperStatus { get; set; }
        public virtual string ImpStatus { get; set; }
        public virtual bool HasFromTerminal { get; set; }
        public virtual bool HasToTerminal { get; set; }
        public virtual string Category { get; set; }
        public virtual string Configuration { get; set; }
        public virtual string Interconnection { get; set; }
        public virtual DateTime RevDate { get; set; }
    }
}
