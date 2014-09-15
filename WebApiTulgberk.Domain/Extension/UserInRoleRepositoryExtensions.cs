using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTulgberk.Domain.Entities;

namespace WebApiTulgberk.Domain.Extension
{
    public static class UserInRoleRepositoryExtensions
    {

        public static bool IsUserInRole(
            this IEntityRepository<UserInRole> userInRoleRepository,
            Guid userKey,
            Guid roleKey)
        {

            var userInRole = userInRoleRepository.GetAll()
                .FirstOrDefault(
                    x => x.UserKey == userKey && x.RoleKey == roleKey);

            return (userInRole != null);
        }
    }
}
