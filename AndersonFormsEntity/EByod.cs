using BaseEntity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonFormsEntity
{
    [Table("Byod")]
    public class EByod : EBase
    {
        public DateTime? ApprovedDate { get; set; }

        public int ApprovedBy { get; set; }
        public int ApproverId { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ByodId { get; set; }
        public int EmployeeId { get; set; }
        public int RequestedBy { get; set; }
        public int TypeOfDeviceId { get; set; }

        [StringLength(50)]
        public string BrandName { get; set; }
        [StringLength(50)]
        public string ContactNo { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string SerialNumber { get; set; }
        
    }
}
