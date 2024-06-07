using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Entities
{
    public class Blog : BaseEntity
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public string Name { get; set; }
        public int BlogTypeId { get; set; }

        public BlogType Blogtype { get; set; }
    }
}
