using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.Core.Entities
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Subject = new HashSet<Subject>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ReadCount { get; set; } = 0;
        public DateTime WritedDate { get; set; } = DateTime.Now;
        public int ReadingTime { get; set; } = 0;


        //User-Article (One-to-many)
        public int? UserId { get; set; }
        public User User { get; set; }
        



        //Article-Subject  Many-to-Many
        public ICollection<Subject> Subject { get; set; }
    }
}
