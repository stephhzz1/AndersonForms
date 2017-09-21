using BaseEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonFormsEntity
{
    [Table("RequestedItem")]
    public class ERequestedItem : EBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public int RequestedItemId { get; set; }
        [Required]
        [StringLength(250)]
        public string Comment { get; set; }
        [Required]
        [StringLength(250)]
        public string ImplementedBy { get; set; }
        [Required]
        [StringLength(250)]
        public string RemovedBy { get; set; }

    }
}

