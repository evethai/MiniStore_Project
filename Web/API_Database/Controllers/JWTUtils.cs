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
        public static string GenerateJWTEmail(String mail)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Email", mail)
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static string GenerateJWTReturn(String fin)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Fin", fin)
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

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
                    new Claim("IsActive", empdto.IsActive.ToString()),
                    new Claim("TimeCheckIn", empdto.TimeCheckIn),
                    new Claim("TimeCheckOut", empdto.TimeCheckOut)
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
/*        public static string GenerateJWTFWSIWSheet(WorkSheetDTO wsdto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim("IdWorkSheet", wsdto.IdWorkSheet)
        }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }*/

        public static string GenerateJWTFWS(WorkSheetDTO wsdto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
            new Claim("Sheet", wsdto.Sheet.ToString()),
            new Claim("TimeCheckIn", wsdto.TimeCheckIn.ToString()),
            new Claim("TimeCheckOut", wsdto.TimeCheckOut.ToString()),
            new Claim("Status", wsdto.Status.ToString())
        }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static string GenerateJWTFSD(List<SheetDetailDTO> wsdto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);

            var claims = new List<Claim>();
            foreach (SheetDetailDTO dto in wsdto)
            {
                claims.Add(new Claim("Sheet", dto.Sheet.ToString()));
                claims.Add(new Claim("ShiftStartTime", dto.ShiftStartTime.ToString()));
                claims.Add(new Claim("ShiftEndTime", dto.ShiftEndTime.ToString()));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của JWT: 1 giờ
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static string GenerateJWTFLWS(List<WorkSheetDTO> wsdto)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);

            var claims = new List<Claim>();
            foreach (WorkSheetDTO dto in wsdto)
            {
                /*claims.Add(new Claim("Sheet", dto.Sheet.ToString()));*/
                claims.Add(new Claim("Date", dto.Date.ToString()));
                claims.Add(new Claim("TimeCheckIn", dto.TimeCheckIn.ToString()));
                claims.Add(new Claim("TimeCheckOut", dto.TimeCheckOut.ToString()));

            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
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
                var claimsPrincipal = tokenHandler.ValidateToken(jwt, validationParameters, out validatedToken);
                return claimsPrincipal;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xác minh JWT: " + ex.Message);
                throw; // Trả về Exception để hiển thị thông báo lỗi cụ thể
            }
        }



    }
}