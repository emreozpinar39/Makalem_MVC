using Makalem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Makalem_MVC.Models
{
    public class ArticleSubjectVM
    {
        public Article Article { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
        public List<int> Ids { get; set; }
    }
}
