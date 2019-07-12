using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLib
{
    public class PasswordGenerator
    {
        private static Random _rand = new Random();
        const string lower = "abcdefghijklmnopqrstuvwxyz";
        const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string number = "1234567890";
        const string special = "!@#$%^&*_-=+";


        public static string GenerateUpper(int lengt=1) {

            var bytes = new byte[lengt];

            new RNGCryptoServiceProvider().GetBytes(bytes);

            var res = new StringBuilder();

            foreach (byte b in bytes) {


                res.Append(upper[b % upper.Count()]);


            }


            return res.ToString();

        }
        public static string GenerateLower(int lengt = 1)
        {

            var bytes = new byte[lengt];

            new RNGCryptoServiceProvider().GetBytes(bytes);

            var res = new StringBuilder();

            foreach (byte b in bytes)
            {


                res.Append(lower[b % lower.Count()]);


            }


            return res.ToString();

        }
        public static string GenerateNumber(int lengt = 1)
        {

            var bytes = new byte[lengt];

            new RNGCryptoServiceProvider().GetBytes(bytes);

            var res = new StringBuilder();

            foreach (byte b in bytes)
            {


                res.Append(number[b % number.Count()]);


            }


            return res.ToString();

        }
        public static string GenerateSpecial(int lengt = 1)
        {

            var bytes = new byte[lengt];

            new RNGCryptoServiceProvider().GetBytes(bytes);

            var res = new StringBuilder();

            foreach (byte b in bytes)
            {


                res.Append(special[b % special.Count()]);


            }


            return res.ToString();

        }


    }
}
