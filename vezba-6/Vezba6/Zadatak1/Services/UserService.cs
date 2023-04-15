using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Data;
using Zadatak1.Interfaces;
using Zadatak1.Models;
using Zadatak1.Models.DTO;

namespace Zadatak1.Services
{
    public class UserService : IUserService
    {
        private readonly IConfigurationSection _secretKey;
        private readonly UserDbContext _dbContext;
        private readonly IMapper _mapper;

        public UserService(IConfiguration config, UserDbContext dbContext, IMapper mapper)
        {
            _secretKey = config.GetSection("SecretKey");
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public string Login(UserDTO dto)
        {
            User user = _dbContext.Users.Where(x => x.Username == dto.Username).FirstOrDefault();

            if (user == null)
            {
                return null;
            }

            if (BCrypt.Net.BCrypt.Verify(dto.Password, user.Password))
            {
                List<Claim> claims = new List<Claim>();

                //if (dto.Username == "petar")
                //{
                //    claims.Add(new Claim(ClaimTypes.Role, "user"));
                //}
                //else if (dto.Username == "marko")
                //{
                //    claims.Add(new Claim(ClaimTypes.Role, "admin"));
                //}

                // Custom claim
                claims.Add(new Claim("CustomClaim", "This is Custom Claim"));

                SymmetricSecurityKey secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey.Value));

                var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var tokenOptions = new JwtSecurityToken(
                    issuer: "http://localhost:44304",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(20),
                    signingCredentials: signingCredentials
                );

                string tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                return tokenString;
            }
            else
            {
                return null;
            }
        }

        public string Register(UserDTO dto)
        {
            if (_dbContext.Users.Where(x => x.Username == dto.Username).FirstOrDefault() != null)
            {
                return null;
            }

            User user = _mapper.Map<User>(dto);
            user.Password = BCrypt.Net.BCrypt.HashPassword(dto.Password, BCrypt.Net.BCrypt.GenerateSalt());

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return user.Username;
        }
    }
}
