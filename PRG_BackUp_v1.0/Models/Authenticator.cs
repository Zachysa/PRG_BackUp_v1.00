using JWT.Algorithms;
using JWT.Builder;
using PRG_BackUp_v1._0.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.Models
{
    public class Authenticator
    {

        public static string SECRECT = "xxx123456";

        public UserRepositary LoginRepository { get; set; } = new UserRepositary();

        public TokensRepositary TokensRepository { get; set; } = new TokensRepositary();

        public Token Authenticate(string username, string password)
        {
            User login = this.LoginRepository.FindByUsername(username);

            if (login == null)
                throw new ArgumentException("Invalid username");

            if (login.Password != password)
                throw new ArgumentException("Invalid password");

            Token token = this.CreateToken(username);
            this.TokensRepository.Insert(token);

            return token;
        }

        private Token CreateToken(string username)
        {
            DateTimeOffset valid = DateTimeOffset.UtcNow.AddHours(1);
            string token = JwtBuilder.Create()
                    .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                    .WithSecret(Authenticator.SECRECT)
                    .AddClaim("exp", valid.ToUnixTimeSeconds())
                    .AddClaim("login", username)
                    .Encode();

            return new Token() { Value = token, ValidUntil = valid.LocalDateTime };
        }

        public void ValidateToken(string token)
        {
            JwtBuilder.Create()
                    .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                    .WithSecret(Authenticator.SECRECT)
                    .MustVerifySignature()
                    .Decode(token);

            Token item = this.TokensRepository.FindByValue(token);

            if (item == null)
                throw new ArgumentException("Token is invalid");
        }

        public void Logout(string value)
        {
            Token token = this.TokensRepository.FindByValue(value);

            this.TokensRepository.Remove(token);
            this.TokensRepository.CleanExpired();
        }
    }
}
