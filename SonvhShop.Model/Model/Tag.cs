﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonvhShop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}
