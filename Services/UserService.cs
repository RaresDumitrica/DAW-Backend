﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DawAppWithAngular.Entities;
using DawAppWithAngular.IRepositories;
using DawAppWithAngular.IServices;
using Microsoft.AspNetCore.Mvc;
using DawAppWithAngular.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using DawAppWithAngular.Mapper;

namespace DawAppWithAngular.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly AppSettings _appSettings;

        public UserService(IUserRepository userRepository, IOptions<AppSettings> appSettings)
        {
            this._userRepository = userRepository;
            this._appSettings = appSettings.Value;
        }

        public bool Register(RegisterRequest request)
        {
            var entity = request.ToUserExtension();

            if (_userRepository.GetByEmail(entity.Email) != null)
            {
                return false;
            }

            _userRepository.Create(entity);
            return _userRepository.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _userRepository.GetUsersAllDetails();
        }

        public User GetById(int id)
        {
            return _userRepository.GetUserAllDetails(id);
        }

        public AuthentificationResponse Login(AuthentificationRequest request)
        {
            // find user
            var user = _userRepository.GetByUserAndPassword(request.Mail, request.Password);
            if (user == null)
                return null;

            // attach token
            var token = GenerateJwtForUser(user);

            // return user & token
            return new AuthentificationResponse
            {
                Id = user.UserId,
                Email = user.Email,
                Token = token
            };
        }

        private string GenerateJwtForUser(User user)
        {
            var key = Encoding.ASCII.GetBytes("Icanputanystringinhere,becausethekeyisastring,andwillbetreatedasso");
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[] { new Claim("id", user.UserId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
