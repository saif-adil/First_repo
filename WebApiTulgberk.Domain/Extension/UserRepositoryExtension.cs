﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTulgberk.Domain.Entities;

namespace WebApiTulgberk.Domain.Extension
{
    public static class UserRepositoryExtensions
    {
        public static User GetSingleByUsername(
        this IEntityRepository<User> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(x => x.Name == username);
        }
    }
}
