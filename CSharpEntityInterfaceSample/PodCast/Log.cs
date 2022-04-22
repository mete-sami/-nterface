using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityInterfaceSample.PodCast
{
    public class Log:BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
    }
}
