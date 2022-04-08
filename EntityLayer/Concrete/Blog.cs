using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbNailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryID { get; set; }
        public int BlogLikes { get; set; }
        public Category category { get; set; }
        public int WriterID { get; set; }
        public Writer Writers { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
