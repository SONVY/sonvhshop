using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonvhShop.Model.Model
{
    [Table("Footers")]
    internal class Footer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Content { get; set; }
    }
}