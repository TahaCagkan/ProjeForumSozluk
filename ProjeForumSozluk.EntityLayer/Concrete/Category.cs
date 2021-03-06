using ProjeForumSozluk.EntityLayer.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.EntityLayer.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        
        //Heading
        public ICollection<Heading> Headings { get; set; }
    }
}
