using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEntityInterfaceSample.PodCast;
namespace CSharpEntityInterfaceSample.PodCast
{
    public class Album:BaseModel
    {
        public string Name { get; set; }
        public List<Single> Singles { get; set; }
        public int SingleCount { get { return Singles.Count(); }  }
        public string BackgroundPic { get; set; }
        Artist artist { get; set; }
    }
}
