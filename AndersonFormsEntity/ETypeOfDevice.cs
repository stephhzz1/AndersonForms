using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonFormsEntity
{
    [Table("TypeOfDevice")]
    public class ETypeOfDevice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TypeOfDeviceId { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}