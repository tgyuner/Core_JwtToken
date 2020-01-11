using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Core_JwtToken.Model;
using Core_JwtToken.Model.Enum;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Core_JwtToken.Helper
{
    /// <summary>
    /// The helper
    /// </summary>
    public class MyHelper : IMyHelper
    {
        private readonly IOptions<AppSettings> _appSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyHelper"/> class.
        /// </summary>
        /// <param name="appSettings">The application settings.</param>
        public MyHelper(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        public User LogIn(string username, string password)
        {
            #region Database Business

            //var user = _userDal.Get(x => x.UserName == username && x.Password == password); TODO

            // Kullanici bulunamadıysa null döner.
            //if (user == null)
            //    return null;

            //// Authentication(Yetkilendirme) başarılı ise JWT token üretilir.
            //var tokenHandler = new JwtSecurityTokenHandler();
            //var key = Encoding.ASCII.GetBytes(_appSettings.Value.Secret);
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new[]
            //    {
            //        new Claim(ClaimTypes.Name, user.Id.ToString())
            //    }),
            //    Expires = DateTime.UtcNow.AddMonths(1),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};
            //var token = tokenHandler.CreateToken(tokenDescriptor);
            //user.PhoneNumber = tokenHandler.WriteToken(token);

            //// Sifre alanı güvenlik sebebi ile sıfırlanır, senaryoya göre şifrelenebilir de...
            //user.Password = null;

            //return user;

            #endregion

            #region Without Database Business

            var user = new User
            {
                Id = 1,
                UserName = "tgy",
                Password = "123456",
                Name = "tugay",
                Surname = "üner",
                Email = "tgy.uner@gmail.com",
                PhoneNumber = "123456798",
                Role = (int)Role.User,
            };

            // Authentication(Yetkilendirme) başarılı ise JWT token üretilir.
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Value.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddMonths(1), // One month
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.PhoneNumber = tokenHandler.WriteToken(token);

            // Sifre alanı güvenlik sebebi ile sıfırlanır, senaryoya göre şifrelenebilir de...
            user.Password = null;

            return user;

            #endregion
        }
    }
}