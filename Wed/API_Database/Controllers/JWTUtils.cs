using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace API_Database.Controllers
{
    public class JWTUtils
    {
        private static readonly string SecretKey = "1Y8NuQTyiWqqXCPiwJeCENE23bJE77ydN92cacjb"; // Thay thế bằng khóa bí mật của bạn

        public static string GenerateJWTFAcc(EmployeeDTO empdto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("IdEmp", empdto.IdEmp),
                    new Claim("FullNameEmp", empdto.FullNameEmp),
                    new Claim("Roles", empdto.Roles),
                    new Claim("IsActive", empdto.IsActive.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static string GenerateJWTFWS(WorkSheetDTO wsdto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim("Sheet", wsdto.Sheet.ToString()),
            new Claim("TimeCheckOut", wsdto.TimeCheckOut.ToString("MM/dd/yyyy HH:mm:ss"))
        }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }


        public static ClaimsPrincipal ValidateJWT(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            try
            {
                SecurityToken validatedToken;
                return tokenHandler.ValidateToken(jwt, validationParameters, out validatedToken);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xác minh JWT: " + ex.Message);
                return null;
            }
        }


    }
}