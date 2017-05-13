using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozyplanes
{
    class PasswordGenerator
    {
        static string generatePswd(int length)
        {
            const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(CHARS[rnd.Next(CHARS.Length)]);
            }
            return res.ToString();
        }
        
        static void Main(string[] args)
        {
            //password length
            int length = 10;
            
            string pass = generatePswd(length);
            Console.Write(pass);
        }
    }
}
