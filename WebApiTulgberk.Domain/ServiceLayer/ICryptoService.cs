using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTulgberk.Api.ServiceLayer
{
    public interface ICryptoService
    {
        string GenerateSalt();
        string EncryptPassword(string password, string salt);
    }
}