using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEntityInterfaceSample.PodCast;
namespace CSharpEntityInterfaceSample.PodCast
{
    public class Favorites:BaseModel
    {
        public User User { get; set; }
        public List<Single> Singles { get; set; }
    }
}
