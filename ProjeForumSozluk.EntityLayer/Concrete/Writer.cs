using ProjeForumSozluk.EntityLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.EntityLayer.Concrete
{
    public class Writer: IEntity
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(100)]
        public string WriterAbout { get; set; }
        [StringLength(50)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public string WriterPassword { get; set; }
        [StringLength(50)]
        public string WriterTitle { get; set; }

        public bool WriterStatus { get; set; }

        //Heading
        public ICollection<Heading> Headings { get; set; }
        //Content
        public ICollection<Content> Contents { get; set; }

    }
}
