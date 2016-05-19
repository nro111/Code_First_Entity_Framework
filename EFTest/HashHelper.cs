using DevOne.Security.Cryptography.BCrypt;
using EFTest.Context;
using EFTest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    static class HashHelper
    {
        //The following signature handles string based inputs
        public static string encode(string data)
        {
            return BCryptHelper.HashPassword(data, BCryptHelper.GenerateSalt());
        }

        public static bool verify(string username, string password)
        {
            bool verified = false;
            
            using (var context = new MyContext())
            {
                var credentials = (from c in context.UserCredentials                                
                                select c).ToList<UserCredential>();
                foreach(var credential in credentials)
                {
                    if (BCryptHelper.CheckPassword(username, credential.Username)
                        && BCryptHelper.CheckPassword(password, credential.Password))
                    {
                        verified = true;
                    }
                }
            }
                
            return verified;
        }
    }
}
