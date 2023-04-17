using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SiriusTech.Data.Interfaces.Services;
using SiriusTech.Data.Models;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SiriusTech.Service.Services
{
    public class TokenServices : ITokenServices
    {
        private readonly SymmetricSecurityKey _chave;
        public TokenServices(IConfiguration configuration)
        {
            _chave = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes
            (configuration["chaveSecreta"]));

        }

        public string CreateToken(Usuario usuario)
        {
            var claims = new List<Claim>
                {
                    new Claim
                    (JwtRegisteredClaimNames.NameId,
                     usuario.DcrUsuario)
                };

            var credenciais = new SigningCredentials(_chave,
            SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = credenciais
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken.WriteToken(token);


        }
    }
}
