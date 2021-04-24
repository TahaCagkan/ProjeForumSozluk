﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //Category
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Writer
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        //Content
        public ICollection<Content> Contents { get; set; }
    }
}