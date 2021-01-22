using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;
using DawAppWithAngular.Models;

namespace DawAppWithAngular.Mapper
{
    public static class UserMapper
    {
        public static User ToUser(AuthentificationRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password
            };
        }

        public static User ToUserExtension(this AuthentificationRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password
            };
        }

        public static User ToUserExtension(this RegisterRequest request)
        {
            return new User
            {
                Email = request.Mail,
                Password = request.Password
            };
        }
    }
}