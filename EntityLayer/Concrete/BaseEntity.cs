using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public abstract class SimpleEntity<T>
    {
        [Key]
        public virtual T Id { get; set; }
    }
    public abstract class BaseEntity<T> : SimpleEntity<T>
    {
        public DateTime? CreatedAt { get; set; } = DateTime.MinValue;
        public Guid? CreatedBy { get; set; } = Guid.Empty;
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        public Guid? DelegationCreatedBy { get; set; }
        public Guid? DelegationUpdatedBy { get; set; }
    }
}
