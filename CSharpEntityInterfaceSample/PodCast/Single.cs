using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEntityInterfaceSample.PodCast;
namespace CSharpEntityInterfaceSample.PodCast
{
    public class Single:BaseModel
    {
        public Single(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public DateTime ReleaseDate {
            get { return ReleaseDate.AddDays(10); }
                }
        public DateTime RemainingTime { get; set; }
        Artist artist { get; set; }
    }
    
}
