using SonvhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Model.Model
{
    [Table("Pages")]
   public class Page : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string Alias { get; set; }
        public string Content { get; set; }
        
    }
}
