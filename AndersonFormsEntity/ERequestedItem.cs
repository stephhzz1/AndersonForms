using BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonFormsEntity
{
    [Table("RequestedItem")]
    public class ERequestedItem : EBase
    {
        public int EmployeeId { get; set; }
        [ForeignKey("Checklist")]
        public int ChecklistId { get; set; }
        public int DepartmentId { get; set; }
        public int ImplementedBy { get; set; }
        public int RemovedBy { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestedItemId { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }

        public virtual EChecklist Checklist { get; set; }
    }
}

