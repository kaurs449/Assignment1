using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Entities
{
    public class Post : BaseEntity
    {
        public int UserId { get; set; } 

        public int PostId { get; set; }
        public string Title { get; set; }
        public string content { get; set; }
        public int PostTypeId { get; set; }
      
        public Blog blog { get; set; }
        public User User { get; set; }
         
        public int BlogId { get; set; }
        
    }
}
