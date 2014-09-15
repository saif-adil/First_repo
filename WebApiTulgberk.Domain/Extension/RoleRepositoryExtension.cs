using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTulgberk.Domain.Entities;

namespace WebApiTulgberk.Domain.Extension
{
    public static class RoleRepositoryExtensions
    {
        public static Role GetSingleByRoleName(
        this IEntityRepository<Role> roleRepository, string roleName)
        {
            return roleRepository.GetAll().FirstOrDefault(x => x.Name == roleName);
        }
    }
}
