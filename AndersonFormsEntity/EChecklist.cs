using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonFormsEntity
{
    [Table("Checklist")]
    public class EChecklist : EBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChecklistId { get; set; }
        public int DepartmentId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<ERequestedItem> RequestedItems { get; set; }
    }
}
