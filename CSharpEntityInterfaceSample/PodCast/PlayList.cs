using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEntityInterfaceSample.PodCast
{
    public class PlayList:BaseModel,IPieceEntity3
    {
        public List<Single> PlayListSings { get; set; }
        public User User { get; set; }
        public int PlayListCount { get => PlayListSings.Count(); }
        public DateTime LastPlayDate { get; set; }
    }
}
