using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.Core.Entities
{
    public class Subject : BaseEntity
    {
        public Subject()
        {
            Article = new HashSet<Article>();
        }
        public string SubjectName { get; set; }



        //Article-Subject  Many-to-Many
        public ICollection<Article> Article { get; set; }



    }
}
