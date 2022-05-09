using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CSharpEntityInterfaceSample.PodCast;
namespace CSharpEntityInterfaceSample.PodCast
{
    public class User:BaseModel
    {
        public User(string name,string surname)
        {
           this.Name= name;
           this.Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Password { get;  }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
