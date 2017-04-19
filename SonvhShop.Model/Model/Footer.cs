using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonvhShop.Model.Model
{
    [Table("Footers")]
    internal class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }
    }
}