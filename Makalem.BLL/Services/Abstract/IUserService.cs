using Makalem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.BLL.Services.Abstract
{
    public interface IUserService : IService<User>
    {
        User CheckUser(User user);
    }
}
