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
   public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength]
        public string Content { get; set; }
        [MaxLength(250)]
        public string MetaKeyword { get; set; }
        [MaxLength(250)]
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
    }
}
