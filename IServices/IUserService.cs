using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;
using DawAppWithAngular.Models;

namespace DawAppWithAngular.IServices
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        bool Register(RegisterRequest request);
        AuthentificationResponse Login(AuthentificationRequest request);
    }
}
