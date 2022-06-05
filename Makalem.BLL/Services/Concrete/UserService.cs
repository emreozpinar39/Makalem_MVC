using Makalem.BLL.Services.Abstract;
using Makalem.Core.Entities;
using Makalem.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.BLL.Services.Concrete
{
    public class UserService : GenericService<User>, IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository _repository) : base(_repository)
        {
            userRepository = _repository;
        }

        public User CheckUser(User user)
        {
            return userRepository.CheckUser(user);
        }
    }
}
