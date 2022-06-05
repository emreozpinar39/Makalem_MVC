using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.Core.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Article = new HashSet<Article>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool Activate { get; set; } = false;
        public DateTime BirthDate { get; set; }
        public string ImagePath { get; set; } = "~/img/user.png";
        public string Email { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }



        //User-Article (One-to-many)
        public ICollection<Article> Article { get; set; }


    }
}
