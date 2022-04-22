using System;
using System.Collections.Generic;
using System.Linq;
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
        
    }
}
